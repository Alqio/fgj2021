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
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e768d98d-346f-4d06-aef5-58d62d262671"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveMouse"",
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
    public struct GameplayMouseActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayMouseActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveMouse => m_Wrapper.m_GameplayMouse_MoveMouse;
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
            }
            m_Wrapper.m_GameplayMouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveMouse.started += instance.OnMoveMouse;
                @MoveMouse.performed += instance.OnMoveMouse;
                @MoveMouse.canceled += instance.OnMoveMouse;
            }
        }
    }
    public GameplayMouseActions @GameplayMouse => new GameplayMouseActions(this);
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
    }
}
