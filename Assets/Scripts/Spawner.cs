using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour {
    public Vector3 SpawnCoordinate;
    public Vector3 HoldCoordinate = new Vector3(-3, 18, 0);
    public int QueueSize = 3;
    public GameObject[] Tetrominoes;

    private int listStep = 4;
    private static List<GameObject> nextTetraminoes = new List<GameObject>( );
    private static GameObject currentTetramino = null;
    private static GameObject holding = null;
    private bool hasSwaped = false;

    private bool isPaused = false;

    private void Awake( ) {
        currentTetramino = null;
        holding = null;
        hasSwaped = false;
        nextTetraminoes.Clear( );
    }

    void Start( ) {
        // Create a queue of pieces
        for (int q = 0; q < QueueSize; q++) {
            SpawnNext( );
            nextTetraminoes[nextTetraminoes.Count - 1].transform.position -=
                new Vector3(0, listStep * q);
        }
        // SpawnNext( );
        CreateTetramino( );
    }

    public void CreateTetramino( ) {
        // remove firstt piece and add a new one tto tthe end of the queue
        hasSwaped = false;
        currentTetramino = nextTetraminoes[0];
        nextTetraminoes.RemoveAt(0);
        currentTetramino.transform.position = SpawnCoordinate;
        currentTetramino.GetComponent<tetrisController>( ).enabled = true;
        currentTetramino.transform.localScale = new Vector3(1f, 1f, 1f);

        foreach (GameObject tetramino in nextTetraminoes) {
            tetramino.transform.position += new Vector3(0, listStep, 0);
        }

        SpawnNext( );
        nextTetraminoes[nextTetraminoes.Count - 1].transform.position -=
            new Vector3(0, listStep * (QueueSize - 1));
    }

    public void HoldTetramino( ) {
        // Swap tetramino with the holding one
        if (hasSwaped) {
            // Can olny be swapped once.
            return;
        }
        hasSwaped = true;
        if (holding != null) {
            // No pieces being holded
            GameObject aux;
            aux = holding;
            holding = currentTetramino;
            aux.transform.position = currentTetramino.transform.position;
            currentTetramino = aux;

            holding.transform.position = HoldCoordinate;
            holding.GetComponent<tetrisController>( ).enabled = false;
            holding.transform.localScale -= new Vector3(0.2f, 0.2f, 0.2f);

            currentTetramino.GetComponent<tetrisController>( ).enabled = true;
            currentTetramino.transform.localScale = new Vector3(1f, 1f, 1f);
        } else {
            // Swap with tthe holding one
            // The holded piece goes to the original piece position
            holding = currentTetramino;
            holding.GetComponent<tetrisController>( ).enabled = false;
            holding.transform.localScale -= new Vector3(0.2f, 0.2f, 0.2f);
            holding.transform.position = HoldCoordinate;
            CreateTetramino( );
            hasSwaped = true;
        }
        AudioManager.playSFX(AudioManager.SoundType.TetrisSwap);
    }

    private void SpawnNext( ) {
        // Creae a new rnadom piece
        int nextID = Random.Range(0, Tetrominoes.Length);
        GameObject nextTetramino = Instantiate(Tetrominoes[nextID],
            transform.position, Quaternion.identity);
        nextTetramino.transform.localScale -= new Vector3(0.2f, 0.2f, 0.2f);
        nextTetramino.GetComponent<tetrisController>( ).enabled = false;
        nextTetraminoes.Add(nextTetramino);
    }

}
