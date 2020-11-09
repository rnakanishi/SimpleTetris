using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.InputSystem;

public class tetrisController : MonoBehaviour {

  #region PublicVariables
  public float fallSeconds = 1f;
  public float moveSpeed = 0.1f;
  public Vector3 rotationPivot;
  public static int width = 10, height = 22;
  public static Transform[, ] grid = new Transform[width, height];
  #endregion

  #region PrivateVariables
  private InputMaster input;
  private float pastFallTime;
  private float pastMoveTime;
  private bool isoMovingDown = false;
  private bool isPaused = false;
  private Vector3 moveDirection = new Vector3(0, 0, 0);
  #endregion

  private void Awake( ) {
    input = new InputMaster( );
    input.Tetrominos.Fall.performed += _ => DropTetromino( );
    input.Tetrominos.Hold.performed += _ => HoldTetramino( );
    input.Tetrominos.RotateCW.performed += _ => RotateTetromino(-90);
    input.Tetrominos.RotateCCW.performed += _ => RotateTetromino(90);
  }

  private void Update( ) {
    // Only move if certain amount of time has passed
    if (Time.time - pastMoveTime > moveSpeed) {
      pastMoveTime = Time.time;
      transform.position += moveDirection;
      if (!IsPositionValid( )) {
        transform.position -= moveDirection;
      }
    }
    // Automattically move piece down if certain amount of time has passed
    if (Time.time - pastFallTime > fallSeconds) {
      pastFallTime = Time.time;
      transform.position += new Vector3(0, -1, 0);
      if (!IsPositionValid( )) {
        transform.position -= new Vector3(0, -1, 0);
        AudioManager.playSFX(AudioManager.SoundType.TetrisDrop);
        if (!CheckGameOver( )) {
          StackTetramino( );
          ClearLine( );
          CreateNewTetramino( );
        } else {
          AudioManager.playSFX(AudioManager.SoundType.GameOver);
          Time.timeScale = 0f;
          this.enabled = false;
          // Load Score UI
          FindObjectOfType<Score>( ).GameOver( );
        }
      }
    }
  }

  private bool CheckGameOver( ) {
    foreach (Transform child in transform) {
      int y;
      y = Mathf.RoundToInt(child.transform.position.y);
      if (y >= 20) {
        Debug.Log("GAME OVER");
        return true;
      }
    }
    return false;
  }

  // Everytime a piece reaches an obstacle, check if line can be cleared
  private void ClearLine( ) {
    List<int> lines = new List<int>( );
    int countLines = 0;
    foreach (Transform child in transform) {
      int y;
      y = Mathf.RoundToInt(child.transform.position.y);
      if (!lines.Contains(y)) {
        lines.Add(y);
      }
    }
    lines.Sort( );
    lines.Reverse( ); // Top lines first
    foreach (int line in lines) {
      bool clearLine = true;
      for (int x = 0; x < width; x++) {
        if (grid[x, line] == null) {
          clearLine = false;
          break;
        }
      }
      if (clearLine) {
        countLines++;
        for (int x = 0; x < width; x++) {
          Destroy(grid[x, line].gameObject);
          grid[x, line] = null;
        }
        for (int y = line + 1; y < height; y++) {
          for (int x = 0; x < width; x++) {
            if (grid[x, y] != null) {
              grid[x, y - 1] = grid[x, y];
              grid[x, y - 1].transform.position -= new Vector3(0, 1, 0);
              grid[x, y] = null;
            }
          }
        }
        AudioManager.playSFX(AudioManager.SoundType.ClearLine);
      }
    }
    FindObjectOfType<Score>( ).IncreaseScore(countLines);
  }

  private void CreateNewTetramino( ) {
    this.enabled = false;
    FindObjectOfType<Spawner>( ).CreateTetramino( );
  }

  private void StackTetramino( ) {
    foreach (Transform child in transform) {
      int x, y;
      x = Mathf.RoundToInt(child.transform.position.x);
      y = Mathf.RoundToInt(child.transform.position.y);
      grid[x, y] = child;
    }
  }

  bool IsPositionValid( ) {
    foreach (Transform child in transform) {
      int x, y;
      x = Mathf.RoundToInt(child.transform.position.x);
      y = Mathf.RoundToInt(child.transform.position.y);
      if (x < 0 || x > width - 1 || y < 0)
        return false;
      if (grid[x, y] != null)
        return false;
    }
    return true;
  }

  private void OnEnable( ) {
    input.Enable( );
  }

  private void OnDisable( ) {
    input.Disable( );
  }

  #region TetrominoMoves
  private void RotateTetromino(float angle) {
    transform.RotateAround(transform.TransformPoint(rotationPivot), new Vector3(0, 0, 1), angle);
    if (!IsPositionValid( )) {
      transform.RotateAround(transform.TransformPoint(rotationPivot), new Vector3(0, 0, 1), -angle);
    }
  }

  public void MoveSideways(InputAction.CallbackContext context) {

    float direction = context.ReadValue<float>( );

    if (context.canceled) {
      moveDirection.x = Mathf.Abs(moveDirection.x) - 1;
    }
    if (context.performed) {
      pastMoveTime = Time.time - 1f * Time.timeScale;
      Vector3 oldPosition = transform.position;
      if (direction < 0f) {
        // transform.position += new Vector3(-1, 0, 0);
        moveDirection = new Vector3(-1, 0, 0);
      } else if (direction > 0) {
        // transform.position += new Vector3(1, 0, 0);
        moveDirection = new Vector3(1, 0, 0);
      }
      // if (!IsPositionValid( )) {
      //   transform.position = oldPosition;
      // }
    }
  }

  public void MoveDown(InputAction.CallbackContext context) {
    if (context.canceled) {
      moveDirection.y = 0;
    }
    if (context.performed) {
      pastMoveTime = Time.time - 1f * Time.timeScale;
      moveDirection += new Vector3(0, -1, 0);
    }
  }

  public void HoldTetramino( ) {
    FindObjectOfType<Spawner>( ).HoldTetramino( );
  }

  private void DropTetromino( ) {
    while (IsPositionValid( )) {
      transform.position += new Vector3(0, -1, 0);
    }
    transform.position -= new Vector3(0, -1, 0);
    AudioManager.playSFX(AudioManager.SoundType.TetrisDrop);
    StackTetramino( );
    ClearLine( );
    CreateNewTetramino( );
  }
  #endregion
}
