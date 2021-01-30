// GENERATED AUTOMATICALLY FROM 'Assets/Scenes/ControlScheme/Player Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Controls"",
    ""maps"": [
        {
            ""name"": ""GameplaySticks"",
            ""id"": ""9ac2ae36-534b-41c0-bd53-b8d4e573fd2d"",
            ""actions"": [
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e13a23cd-cd4e-4ea9-a3f2-8581d5deac7e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""PassThrough"",
                    ""id"": ""100fad6e-f698-47e5-9244-c9bad37bb583"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""84da5471-76ee-46cc-9f6a-d096866080ee"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d0bbcfc-82a3-4b8a-a93b-65a40f0d6340"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GameplayKeyboard"",
            ""id"": ""92f2ae51-78ee-4310-b886-8c79bd42ed82"",
            ""actions"": [
                {
                    ""name"": ""WASD"",
                    ""type"": ""Value"",
                    ""id"": ""f06ebbef-9e4b-4b40-a66b-b63572ee840f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Arrows"",
                    ""type"": ""Value"",
                    ""id"": ""1e701cff-d476-4fcc-b7b0-2012fb5c4780"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""e62e44cc-7f8f-4581-9818-720249e752ac"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9a65396f-2747-4367-add2-a5bafa72c916"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c6a3399c-e70e-4dbc-aa30-c1622352d173"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7a5e53d4-4376-494d-a9eb-2ddcb5078e67"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5fe27beb-ec93-424c-b4bd-13156b6f77ba"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f3569840-bf6d-48cc-8ceb-5015582ac252"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Arrows"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b8864153-b7d8-4aa6-857f-207cb02de01d"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Arrows"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9105172b-1afc-4184-8944-f1bdb5d5c832"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Arrows"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ed5ac692-0c5a-4f30-9037-9eafab26b67d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Arrows"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9e35bcb3-a984-4f16-8131-dc8f40336199"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Arrows"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""GameplayMouse"",
            ""id"": ""e4e720db-9457-4b45-ae3d-2d899854ab1c"",
            ""actions"": [
                {
                    ""name"": ""MoveMouse"",
                    ""type"": ""PassThrough"",
                    ""id"": ""788baae4-1d6c-45f9-a3b6-1871fbe120bd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ClickMouse"",
                    ""type"": ""Button"",
                    ""id"": ""c5c2d27c-f550-4118-80c6-8afb311a1236"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e768d98d-346f-4d06-aef5-58d62d262671"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb7e926e-a3b1-4933-9912-4e89f999371b"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ClickMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MenuActions"",
            ""id"": ""9427d60e-18ca-43bd-aa93-16c92aba3cca"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""706d4118-862a-4ef2-9d41-22b38cd2932e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MenuMove"",
                    ""type"": ""Button"",
                    ""id"": ""effeb41a-0fe4-419e-ada5-936bfc24d1fe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""Normalize(min=-1,max=1)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MenuConfirm"",
                    ""type"": ""Button"",
                    ""id"": ""5f642b5e-5cd2-4706-ace6-5cc2002d42ff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""Normalize(min=-1,max=1)"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""21bb7d22-2c2d-4d9b-a2d6-c7229a350f95"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""d549d29b-5823-414b-ab21-f79f32dc65b4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""dbce3c85-e1bc-49bb-91fe-1c85b0e617b6"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""18e37fe5-8cf9-459f-a9f7-658b2650770b"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""6454df85-b03c-430b-8691-92bf8ab5e539"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4cd6ca60-f274-490d-9fc0-6975eef43a6a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""263b99e7-5fca-455c-bc07-a8cd6a334444"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Joystick"",
                    ""id"": ""25ee31d0-a3c6-41b9-9184-37925d7e9252"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9dbc5a14-2af8-43e2-9696-b9c889fabc22"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""632ada2c-e9da-4fb4-9fc5-f02a1b406ad5"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""GamepadRightStick"",
                    ""id"": ""f8fdded7-d2fa-4fb8-a095-75829fd35c44"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""94b7a75b-45dc-4669-9e2f-dd4de64cfaad"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e9ed551b-a5f5-4442-a955-37b5dc00d7ff"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""GamepadLeftStick"",
                    ""id"": ""bd1ac7a6-9567-49e1-8c6a-ebb5bb570e94"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5bff3dc4-82f0-45aa-ad9f-7c3cb106ad66"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d683a068-ad43-42fa-a9c0-d1d141f6048a"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""GamepadDPad"",
                    ""id"": ""a5d95d17-fd05-4c81-88c9-24aa5943103b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""748193e2-2545-4f5d-a51f-7c5b6a22ad27"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""62b9c6fc-1f8b-4e66-98c3-3b94dbe62229"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0e4e07c4-1197-4070-b125-eb35b9cbf621"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuConfirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ffc088f-ac2b-4b30-8a82-1e68a54c5a9a"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuConfirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""829c1fb4-0c01-46c9-a6fa-31672af15b47"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuConfirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f0e2609-f90a-4841-8fad-96b276e2ba2d"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuConfirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GameplayTouchscreen"",
            ""id"": ""40b88df6-b3b1-4ecd-a0be-2f9acc66620a"",
            ""actions"": [
                {
                    ""name"": ""Tap"",
                    ""type"": ""Button"",
                    ""id"": ""a22606db-31fd-42f3-afee-c8832d69b974"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7c124945-5ff4-45dd-9389-74cf1c97675a"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GameplaySticks
        m_GameplaySticks = asset.FindActionMap("GameplaySticks", throwIfNotFound: true);
        m_GameplaySticks_MoveRight = m_GameplaySticks.FindAction("MoveRight", throwIfNotFound: true);
        m_GameplaySticks_MoveLeft = m_GameplaySticks.FindAction("MoveLeft", throwIfNotFound: true);
        // GameplayKeyboard
        m_GameplayKeyboard = asset.FindActionMap("GameplayKeyboard", throwIfNotFound: true);
        m_GameplayKeyboard_WASD = m_GameplayKeyboard.FindAction("WASD", throwIfNotFound: true);
        m_GameplayKeyboard_Arrows = m_GameplayKeyboard.FindAction("Arrows", throwIfNotFound: true);
        // GameplayMouse
        m_GameplayMouse = asset.FindActionMap("GameplayMouse", throwIfNotFound: true);
        m_GameplayMouse_MoveMouse = m_GameplayMouse.FindAction("MoveMouse", throwIfNotFound: true);
        m_GameplayMouse_ClickMouse = m_GameplayMouse.FindAction("ClickMouse", throwIfNotFound: true);
        // MenuActions
        m_MenuActions = asset.FindActionMap("MenuActions", throwIfNotFound: true);
        m_MenuActions_Pause = m_MenuActions.FindAction("Pause", throwIfNotFound: true);
        m_MenuActions_MenuMove = m_MenuActions.FindAction("MenuMove", throwIfNotFound: true);
        m_MenuActions_MenuConfirm = m_MenuActions.FindAction("MenuConfirm", throwIfNotFound: true);
        // GameplayTouchscreen
        m_GameplayTouchscreen = asset.FindActionMap("GameplayTouchscreen", throwIfNotFound: true);
        m_GameplayTouchscreen_Tap = m_GameplayTouchscreen.FindAction("Tap", throwIfNotFound: true);
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

    // GameplaySticks
    private readonly InputActionMap m_GameplaySticks;
    private IGameplaySticksActions m_GameplaySticksActionsCallbackInterface;
    private readonly InputAction m_GameplaySticks_MoveRight;
    private readonly InputAction m_GameplaySticks_MoveLeft;
    public struct GameplaySticksActions
    {
        private @PlayerControls m_Wrapper;
        public GameplaySticksActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveRight => m_Wrapper.m_GameplaySticks_MoveRight;
        public InputAction @MoveLeft => m_Wrapper.m_GameplaySticks_MoveLeft;
        public InputActionMap Get() { return m_Wrapper.m_GameplaySticks; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplaySticksActions set) { return set.Get(); }
        public void SetCallbacks(IGameplaySticksActions instance)
        {
            if (m_Wrapper.m_GameplaySticksActionsCallbackInterface != null)
            {
                @MoveRight.started -= m_Wrapper.m_GameplaySticksActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_GameplaySticksActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_GameplaySticksActionsCallbackInterface.OnMoveRight;
                @MoveLeft.started -= m_Wrapper.m_GameplaySticksActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_GameplaySticksActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_GameplaySticksActionsCallbackInterface.OnMoveLeft;
            }
            m_Wrapper.m_GameplaySticksActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
            }
        }
    }
    public GameplaySticksActions @GameplaySticks => new GameplaySticksActions(this);

    // GameplayKeyboard
    private readonly InputActionMap m_GameplayKeyboard;
    private IGameplayKeyboardActions m_GameplayKeyboardActionsCallbackInterface;
    private readonly InputAction m_GameplayKeyboard_WASD;
    private readonly InputAction m_GameplayKeyboard_Arrows;
    public struct GameplayKeyboardActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayKeyboardActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @WASD => m_Wrapper.m_GameplayKeyboard_WASD;
        public InputAction @Arrows => m_Wrapper.m_GameplayKeyboard_Arrows;
        public InputActionMap Get() { return m_Wrapper.m_GameplayKeyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayKeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayKeyboardActions instance)
        {
            if (m_Wrapper.m_GameplayKeyboardActionsCallbackInterface != null)
            {
                @WASD.started -= m_Wrapper.m_GameplayKeyboardActionsCallbackInterface.OnWASD;
                @WASD.performed -= m_Wrapper.m_GameplayKeyboardActionsCallbackInterface.OnWASD;
                @WASD.canceled -= m_Wrapper.m_GameplayKeyboardActionsCallbackInterface.OnWASD;
                @Arrows.started -= m_Wrapper.m_GameplayKeyboardActionsCallbackInterface.OnArrows;
                @Arrows.performed -= m_Wrapper.m_GameplayKeyboardActionsCallbackInterface.OnArrows;
                @Arrows.canceled -= m_Wrapper.m_GameplayKeyboardActionsCallbackInterface.OnArrows;
            }
            m_Wrapper.m_GameplayKeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @WASD.started += instance.OnWASD;
                @WASD.performed += instance.OnWASD;
                @WASD.canceled += instance.OnWASD;
                @Arrows.started += instance.OnArrows;
                @Arrows.performed += instance.OnArrows;
                @Arrows.canceled += instance.OnArrows;
            }
        }
    }
    public GameplayKeyboardActions @GameplayKeyboard => new GameplayKeyboardActions(this);

    // GameplayMouse
    private readonly InputActionMap m_GameplayMouse;
    private IGameplayMouseActions m_GameplayMouseActionsCallbackInterface;
    private readonly InputAction m_GameplayMouse_MoveMouse;
    private readonly InputAction m_GameplayMouse_ClickMouse;
    public struct GameplayMouseActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayMouseActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveMouse => m_Wrapper.m_GameplayMouse_MoveMouse;
        public InputAction @ClickMouse => m_Wrapper.m_GameplayMouse_ClickMouse;
        public InputActionMap Get() { return m_Wrapper.m_GameplayMouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayMouseActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayMouseActions instance)
        {
            if (m_Wrapper.m_GameplayMouseActionsCallbackInterface != null)
            {
                @MoveMouse.started -= m_Wrapper.m_GameplayMouseActionsCallbackInterface.OnMoveMouse;
                @MoveMouse.performed -= m_Wrapper.m_GameplayMouseActionsCallbackInterface.OnMoveMouse;
                @MoveMouse.canceled -= m_Wrapper.m_GameplayMouseActionsCallbackInterface.OnMoveMouse;
                @ClickMouse.started -= m_Wrapper.m_GameplayMouseActionsCallbackInterface.OnClickMouse;
                @ClickMouse.performed -= m_Wrapper.m_GameplayMouseActionsCallbackInterface.OnClickMouse;
                @ClickMouse.canceled -= m_Wrapper.m_GameplayMouseActionsCallbackInterface.OnClickMouse;
            }
            m_Wrapper.m_GameplayMouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveMouse.started += instance.OnMoveMouse;
                @MoveMouse.performed += instance.OnMoveMouse;
                @MoveMouse.canceled += instance.OnMoveMouse;
                @ClickMouse.started += instance.OnClickMouse;
                @ClickMouse.performed += instance.OnClickMouse;
                @ClickMouse.canceled += instance.OnClickMouse;
            }
        }
    }
    public GameplayMouseActions @GameplayMouse => new GameplayMouseActions(this);

    // MenuActions
    private readonly InputActionMap m_MenuActions;
    private IMenuActionsActions m_MenuActionsActionsCallbackInterface;
    private readonly InputAction m_MenuActions_Pause;
    private readonly InputAction m_MenuActions_MenuMove;
    private readonly InputAction m_MenuActions_MenuConfirm;
    public struct MenuActionsActions
    {
        private @PlayerControls m_Wrapper;
        public MenuActionsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_MenuActions_Pause;
        public InputAction @MenuMove => m_Wrapper.m_MenuActions_MenuMove;
        public InputAction @MenuConfirm => m_Wrapper.m_MenuActions_MenuConfirm;
        public InputActionMap Get() { return m_Wrapper.m_MenuActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActionsActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActionsActions instance)
        {
            if (m_Wrapper.m_MenuActionsActionsCallbackInterface != null)
            {
                @Pause.started -= m_Wrapper.m_MenuActionsActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_MenuActionsActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_MenuActionsActionsCallbackInterface.OnPause;
                @MenuMove.started -= m_Wrapper.m_MenuActionsActionsCallbackInterface.OnMenuMove;
                @MenuMove.performed -= m_Wrapper.m_MenuActionsActionsCallbackInterface.OnMenuMove;
                @MenuMove.canceled -= m_Wrapper.m_MenuActionsActionsCallbackInterface.OnMenuMove;
                @MenuConfirm.started -= m_Wrapper.m_MenuActionsActionsCallbackInterface.OnMenuConfirm;
                @MenuConfirm.performed -= m_Wrapper.m_MenuActionsActionsCallbackInterface.OnMenuConfirm;
                @MenuConfirm.canceled -= m_Wrapper.m_MenuActionsActionsCallbackInterface.OnMenuConfirm;
            }
            m_Wrapper.m_MenuActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @MenuMove.started += instance.OnMenuMove;
                @MenuMove.performed += instance.OnMenuMove;
                @MenuMove.canceled += instance.OnMenuMove;
                @MenuConfirm.started += instance.OnMenuConfirm;
                @MenuConfirm.performed += instance.OnMenuConfirm;
                @MenuConfirm.canceled += instance.OnMenuConfirm;
            }
        }
    }
    public MenuActionsActions @MenuActions => new MenuActionsActions(this);

    // GameplayTouchscreen
    private readonly InputActionMap m_GameplayTouchscreen;
    private IGameplayTouchscreenActions m_GameplayTouchscreenActionsCallbackInterface;
    private readonly InputAction m_GameplayTouchscreen_Tap;
    public struct GameplayTouchscreenActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayTouchscreenActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Tap => m_Wrapper.m_GameplayTouchscreen_Tap;
        public InputActionMap Get() { return m_Wrapper.m_GameplayTouchscreen; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayTouchscreenActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayTouchscreenActions instance)
        {
            if (m_Wrapper.m_GameplayTouchscreenActionsCallbackInterface != null)
            {
                @Tap.started -= m_Wrapper.m_GameplayTouchscreenActionsCallbackInterface.OnTap;
                @Tap.performed -= m_Wrapper.m_GameplayTouchscreenActionsCallbackInterface.OnTap;
                @Tap.canceled -= m_Wrapper.m_GameplayTouchscreenActionsCallbackInterface.OnTap;
            }
            m_Wrapper.m_GameplayTouchscreenActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Tap.started += instance.OnTap;
                @Tap.performed += instance.OnTap;
                @Tap.canceled += instance.OnTap;
            }
        }
    }
    public GameplayTouchscreenActions @GameplayTouchscreen => new GameplayTouchscreenActions(this);
    public interface IGameplaySticksActions
    {
        void OnMoveRight(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
    }
    public interface IGameplayKeyboardActions
    {
        void OnWASD(InputAction.CallbackContext context);
        void OnArrows(InputAction.CallbackContext context);
    }
    public interface IGameplayMouseActions
    {
        void OnMoveMouse(InputAction.CallbackContext context);
        void OnClickMouse(InputAction.CallbackContext context);
    }
    public interface IMenuActionsActions
    {
        void OnPause(InputAction.CallbackContext context);
        void OnMenuMove(InputAction.CallbackContext context);
        void OnMenuConfirm(InputAction.CallbackContext context);
    }
    public interface IGameplayTouchscreenActions
    {
        void OnTap(InputAction.CallbackContext context);
    }
}
