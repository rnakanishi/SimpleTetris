// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Tetrominos"",
            ""id"": ""d2678355-b12e-485f-b716-9416383663a7"",
            ""actions"": [
                {
                    ""name"": ""Fall"",
                    ""type"": ""Button"",
                    ""id"": ""fdf8bdd5-a0fb-45b1-afdf-cc5efe223858"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate CW"",
                    ""type"": ""Button"",
                    ""id"": ""06b8c387-bcbe-47fc-825c-ecaf0c3c89c9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate CCW"",
                    ""type"": ""Button"",
                    ""id"": ""6b65028c-3912-4db3-9cd2-2eff577c979a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move Down"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8a9f1da7-f3fb-4eaa-8ccd-c9407b3ba1f6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(pressPoint=0.05,behavior=2)""
                },
                {
                    ""name"": ""Sideway"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d9e0c028-ac45-4397-81f7-dd9d0b97127c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(pressPoint=0.1,behavior=2)""
                },
                {
                    ""name"": ""Hold"",
                    ""type"": ""Button"",
                    ""id"": ""ffb08118-bf2f-4113-8cee-b1a165c47587"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(pressPoint=0.1,behavior=2)""
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""33beba14-a16c-4f2d-bea4-4c0bcd0c86ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(pressPoint=0.1,behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a1a994cb-5051-408d-9247-af8960ea0387"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Fall"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14b32246-d632-41d4-be14-8a571c1d5d4c"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Rotate CW"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a453ba3-a337-44d4-a686-8d589c5c7ae4"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Rotate CCW"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3871aa4b-b7c4-419f-899b-9b9b310fc5e9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Rotate CCW"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a31e369-106b-4ffd-b98f-1b260b8caf02"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate CCW"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""647546e3-1099-4617-841c-14efd5dbf04f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5475a458-ef6a-42ea-935d-979075af984a"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrow"",
                    ""id"": ""e97adcb6-2565-4f45-8747-4c250a26f160"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sideway"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f30c295c-2a57-46a6-b12c-6de69b34bcef"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": ""Clamp(max=1),Normalize(max=1)"",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Sideway"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f186b38c-88bc-428f-afd8-1957ab7b9341"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Sideway"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""9d43a16d-d797-4309-884f-e0ba236ef15b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sideway"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d8546b64-569f-44e3-9f0d-ea0a11bc9057"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Sideway"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8a3ac405-0eb2-4cbd-9110-d6406f3422dc"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Sideway"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8f3146af-ade1-4566-9b99-c20d40461feb"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a28d31c-42dc-4e3e-b20c-4fb60102bf45"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""9bb81cbb-aff7-4e45-bce4-ab80677f58c4"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""8bde25d2-f19a-4225-84a7-bd4e75a57105"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""f9174808-1f65-4de9-a1cd-f068ebe4bb89"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""3085efc2-f501-4961-8cb7-b07b524a6cbe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""3c98d381-8ad3-45e3-9bae-5baae0929be3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""2b6978a5-a057-45c1-9c43-df7af5afbe92"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""a2a15582-7848-492f-814e-e5876d66196b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""67d99d2f-ad17-4375-958d-f6c505d110d9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""508763fd-5989-4f76-8078-637e58b9bd4d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ac59f257-03b3-45d1-8054-ec3a98c1d274"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9279920a-0966-480d-8456-de0ab38b63d5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""d3e9e45e-f7af-4939-ad53-aac079c72757"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""15ee74bf-5dfa-465e-8e30-d7b6adea1fc8"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d6400ca0-e6d9-402e-b9ef-18f5f9de821f"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ddbed6d2-e6cb-4d45-8f38-9ba46f058f01"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a4e0a155-b14f-4535-a688-8271ef5b4315"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""05a379da-bbab-4f06-8d6d-053b8220ed78"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""08c290d3-58a9-45c7-b9fd-3d36ff0a4f81"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c7fba8a9-fcd3-4685-a766-4fd56b5ab67e"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e1c6e8a-742c-4e64-9bd3-ba78eabbec18"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Tetrominos
        m_Tetrominos = asset.FindActionMap("Tetrominos", throwIfNotFound: true);
        m_Tetrominos_Fall = m_Tetrominos.FindAction("Fall", throwIfNotFound: true);
        m_Tetrominos_RotateCW = m_Tetrominos.FindAction("Rotate CW", throwIfNotFound: true);
        m_Tetrominos_RotateCCW = m_Tetrominos.FindAction("Rotate CCW", throwIfNotFound: true);
        m_Tetrominos_MoveDown = m_Tetrominos.FindAction("Move Down", throwIfNotFound: true);
        m_Tetrominos_Sideway = m_Tetrominos.FindAction("Sideway", throwIfNotFound: true);
        m_Tetrominos_Hold = m_Tetrominos.FindAction("Hold", throwIfNotFound: true);
        m_Tetrominos_Pause = m_Tetrominos.FindAction("Pause", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Move = m_UI.FindAction("Move", throwIfNotFound: true);
        m_UI_Submit = m_UI.FindAction("Submit", throwIfNotFound: true);
        m_UI_Cancel = m_UI.FindAction("Cancel", throwIfNotFound: true);
        m_UI_Click = m_UI.FindAction("Click", throwIfNotFound: true);
        m_UI_Pause = m_UI.FindAction("Pause", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Tetrominos
    private readonly InputActionMap m_Tetrominos;
    private ITetrominosActions m_TetrominosActionsCallbackInterface;
    private readonly InputAction m_Tetrominos_Fall;
    private readonly InputAction m_Tetrominos_RotateCW;
    private readonly InputAction m_Tetrominos_RotateCCW;
    private readonly InputAction m_Tetrominos_MoveDown;
    private readonly InputAction m_Tetrominos_Sideway;
    private readonly InputAction m_Tetrominos_Hold;
    private readonly InputAction m_Tetrominos_Pause;
    public struct TetrominosActions
    {
        private @InputMaster m_Wrapper;
        public TetrominosActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fall => m_Wrapper.m_Tetrominos_Fall;
        public InputAction @RotateCW => m_Wrapper.m_Tetrominos_RotateCW;
        public InputAction @RotateCCW => m_Wrapper.m_Tetrominos_RotateCCW;
        public InputAction @MoveDown => m_Wrapper.m_Tetrominos_MoveDown;
        public InputAction @Sideway => m_Wrapper.m_Tetrominos_Sideway;
        public InputAction @Hold => m_Wrapper.m_Tetrominos_Hold;
        public InputAction @Pause => m_Wrapper.m_Tetrominos_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Tetrominos; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TetrominosActions set) { return set.Get(); }
        public void SetCallbacks(ITetrominosActions instance)
        {
            if (m_Wrapper.m_TetrominosActionsCallbackInterface != null)
            {
                @Fall.started -= m_Wrapper.m_TetrominosActionsCallbackInterface.OnFall;
                @Fall.performed -= m_Wrapper.m_TetrominosActionsCallbackInterface.OnFall;
                @Fall.canceled -= m_Wrapper.m_TetrominosActionsCallbackInterface.OnFall;
                @RotateCW.started -= m_Wrapper.m_TetrominosActionsCallbackInterface.OnRotateCW;
                @RotateCW.performed -= m_Wrapper.m_TetrominosActionsCallbackInterface.OnRotateCW;
                @RotateCW.canceled -= m_Wrapper.m_TetrominosActionsCallbackInterface.OnRotateCW;
                @RotateCCW.started -= m_Wrapper.m_TetrominosActionsCallbackInterface.OnRotateCCW;
                @RotateCCW.performed -= m_Wrapper.m_TetrominosActionsCallbackInterface.OnRotateCCW;
                @RotateCCW.canceled -= m_Wrapper.m_TetrominosActionsCallbackInterface.OnRotateCCW;
                @MoveDown.started -= m_Wrapper.m_TetrominosActionsCallbackInterface.OnMoveDown;
                @MoveDown.performed -= m_Wrapper.m_TetrominosActionsCallbackInterface.OnMoveDown;
                @MoveDown.canceled -= m_Wrapper.m_TetrominosActionsCallbackInterface.OnMoveDown;
                @Sideway.started -= m_Wrapper.m_TetrominosActionsCallbackInterface.OnSideway;
                @Sideway.performed -= m_Wrapper.m_TetrominosActionsCallbackInterface.OnSideway;
                @Sideway.canceled -= m_Wrapper.m_TetrominosActionsCallbackInterface.OnSideway;
                @Hold.started -= m_Wrapper.m_TetrominosActionsCallbackInterface.OnHold;
                @Hold.performed -= m_Wrapper.m_TetrominosActionsCallbackInterface.OnHold;
                @Hold.canceled -= m_Wrapper.m_TetrominosActionsCallbackInterface.OnHold;
                @Pause.started -= m_Wrapper.m_TetrominosActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_TetrominosActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_TetrominosActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_TetrominosActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Fall.started += instance.OnFall;
                @Fall.performed += instance.OnFall;
                @Fall.canceled += instance.OnFall;
                @RotateCW.started += instance.OnRotateCW;
                @RotateCW.performed += instance.OnRotateCW;
                @RotateCW.canceled += instance.OnRotateCW;
                @RotateCCW.started += instance.OnRotateCCW;
                @RotateCCW.performed += instance.OnRotateCCW;
                @RotateCCW.canceled += instance.OnRotateCCW;
                @MoveDown.started += instance.OnMoveDown;
                @MoveDown.performed += instance.OnMoveDown;
                @MoveDown.canceled += instance.OnMoveDown;
                @Sideway.started += instance.OnSideway;
                @Sideway.performed += instance.OnSideway;
                @Sideway.canceled += instance.OnSideway;
                @Hold.started += instance.OnHold;
                @Hold.performed += instance.OnHold;
                @Hold.canceled += instance.OnHold;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public TetrominosActions @Tetrominos => new TetrominosActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Move;
    private readonly InputAction m_UI_Submit;
    private readonly InputAction m_UI_Cancel;
    private readonly InputAction m_UI_Click;
    private readonly InputAction m_UI_Pause;
    public struct UIActions
    {
        private @InputMaster m_Wrapper;
        public UIActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_UI_Move;
        public InputAction @Submit => m_Wrapper.m_UI_Submit;
        public InputAction @Cancel => m_Wrapper.m_UI_Cancel;
        public InputAction @Click => m_Wrapper.m_UI_Click;
        public InputAction @Pause => m_Wrapper.m_UI_Pause;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMove;
                @Submit.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Cancel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Pause.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface ITetrominosActions
    {
        void OnFall(InputAction.CallbackContext context);
        void OnRotateCW(InputAction.CallbackContext context);
        void OnRotateCCW(InputAction.CallbackContext context);
        void OnMoveDown(InputAction.CallbackContext context);
        void OnSideway(InputAction.CallbackContext context);
        void OnHold(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
