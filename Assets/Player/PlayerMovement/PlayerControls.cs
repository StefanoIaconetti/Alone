// GENERATED AUTOMATICALLY FROM 'Assets/Player/PlayerMovement/PlayerControls.inputactions'

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
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""APlayerMovement"",
            ""id"": ""5aac0724-c9d6-40e4-a37f-b920101bb0f6"",
            ""actions"": [
                {
                    ""name"": ""LeftJoystickMovement"",
                    ""type"": ""Button"",
                    ""id"": ""b3b9c078-69b8-4c98-9996-100b45613218"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightJoystickMovement"",
                    ""type"": ""Button"",
                    ""id"": ""f6d5a8f3-03b8-4cdb-bb0d-6e9106c29ac4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AButtonPress"",
                    ""type"": ""Button"",
                    ""id"": ""eef13c5c-9449-45f0-8f4f-d9d1503bc49c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Hold,Tap""
                },
                {
                    ""name"": ""XButtonHold"",
                    ""type"": ""Button"",
                    ""id"": ""2ce575fe-92c7-420f-a914-f85d24194f4c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""RTButtonPress"",
                    ""type"": ""Button"",
                    ""id"": ""46223c37-0f22-4f55-b942-f152144271a8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""BButtonPress"",
                    ""type"": ""Button"",
                    ""id"": ""5acafbe6-4b97-4436-8463-d07a886b454e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""RightDPad"",
                    ""type"": ""Button"",
                    ""id"": ""306dbe0e-8f0c-43be-a3f8-e178c747e2ff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""LeftDPad"",
                    ""type"": ""Button"",
                    ""id"": ""3008eb5b-7e6c-4980-819c-cdbb187340e7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""LeftBumperHold"",
                    ""type"": ""Button"",
                    ""id"": ""5c7aa5e9-23b0-4cbc-be87-70c3afa75f60"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3a8b4cb6-434a-4379-a5ea-9b99aa32d985"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftJoystickMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""35d34e7c-bacf-4df0-9946-bbcd04ad4c04"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightJoystickMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf880a44-9b7d-4d62-a74d-500f13dc942f"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AButtonPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""814da7f5-c72b-4bab-ba59-9b8bacf00879"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""XButtonHold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""56518949-4988-4de5-93bd-1580296e406a"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RTButtonPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fff9c571-e31b-488e-9c44-ddadd8946ab2"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BButtonPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""844cb1bf-fcf8-43b6-bc09-1653ae0d0cc6"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightDPad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ddf23b12-e776-40b5-a0f2-15fa5aef427a"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftDPad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""22a8188d-d49f-4fb7-a678-87c220b15f56"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftBumperHold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""ce8ebc90-734d-4e95-88ec-6f41cfca701e"",
            ""actions"": [
                {
                    ""name"": ""LeftStickMove"",
                    ""type"": ""Button"",
                    ""id"": ""c97560c3-6f2a-46bb-9785-c42cbe2f40d3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AButtonPress"",
                    ""type"": ""Button"",
                    ""id"": ""35f02ec4-9657-41e0-a567-0e6569b059f7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DPadMove"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6c6a272d-cf29-4f09-bd1b-412f0052684f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2540f858-c5c5-4684-bbc4-f3e091416ce0"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone(min=0.7,max=3)"",
                    ""groups"": """",
                    ""action"": ""LeftStickMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c68463ae-7440-48e5-8df0-afef489e4782"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AButtonPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""a96f48f6-9abb-41b8-87b1-9507964a9065"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPadMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7f91ba31-7241-4979-a3b2-d269bdb3445a"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPadMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0418e621-246c-4d11-b95c-6af8ea29c99c"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPadMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fdbc6b99-6f47-4d21-b269-16e3e9e1722b"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPadMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e43af1a0-be96-48d4-8eb3-800839868e54"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPadMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // APlayerMovement
        m_APlayerMovement = asset.FindActionMap("APlayerMovement", throwIfNotFound: true);
        m_APlayerMovement_LeftJoystickMovement = m_APlayerMovement.FindAction("LeftJoystickMovement", throwIfNotFound: true);
        m_APlayerMovement_RightJoystickMovement = m_APlayerMovement.FindAction("RightJoystickMovement", throwIfNotFound: true);
        m_APlayerMovement_AButtonPress = m_APlayerMovement.FindAction("AButtonPress", throwIfNotFound: true);
        m_APlayerMovement_XButtonHold = m_APlayerMovement.FindAction("XButtonHold", throwIfNotFound: true);
        m_APlayerMovement_RTButtonPress = m_APlayerMovement.FindAction("RTButtonPress", throwIfNotFound: true);
        m_APlayerMovement_BButtonPress = m_APlayerMovement.FindAction("BButtonPress", throwIfNotFound: true);
        m_APlayerMovement_RightDPad = m_APlayerMovement.FindAction("RightDPad", throwIfNotFound: true);
        m_APlayerMovement_LeftDPad = m_APlayerMovement.FindAction("LeftDPad", throwIfNotFound: true);
        m_APlayerMovement_LeftBumperHold = m_APlayerMovement.FindAction("LeftBumperHold", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_LeftStickMove = m_UI.FindAction("LeftStickMove", throwIfNotFound: true);
        m_UI_AButtonPress = m_UI.FindAction("AButtonPress", throwIfNotFound: true);
        m_UI_DPadMove = m_UI.FindAction("DPadMove", throwIfNotFound: true);
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

    // APlayerMovement
    private readonly InputActionMap m_APlayerMovement;
    private IAPlayerMovementActions m_APlayerMovementActionsCallbackInterface;
    private readonly InputAction m_APlayerMovement_LeftJoystickMovement;
    private readonly InputAction m_APlayerMovement_RightJoystickMovement;
    private readonly InputAction m_APlayerMovement_AButtonPress;
    private readonly InputAction m_APlayerMovement_XButtonHold;
    private readonly InputAction m_APlayerMovement_RTButtonPress;
    private readonly InputAction m_APlayerMovement_BButtonPress;
    private readonly InputAction m_APlayerMovement_RightDPad;
    private readonly InputAction m_APlayerMovement_LeftDPad;
    private readonly InputAction m_APlayerMovement_LeftBumperHold;
    public struct APlayerMovementActions
    {
        private @PlayerControls m_Wrapper;
        public APlayerMovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftJoystickMovement => m_Wrapper.m_APlayerMovement_LeftJoystickMovement;
        public InputAction @RightJoystickMovement => m_Wrapper.m_APlayerMovement_RightJoystickMovement;
        public InputAction @AButtonPress => m_Wrapper.m_APlayerMovement_AButtonPress;
        public InputAction @XButtonHold => m_Wrapper.m_APlayerMovement_XButtonHold;
        public InputAction @RTButtonPress => m_Wrapper.m_APlayerMovement_RTButtonPress;
        public InputAction @BButtonPress => m_Wrapper.m_APlayerMovement_BButtonPress;
        public InputAction @RightDPad => m_Wrapper.m_APlayerMovement_RightDPad;
        public InputAction @LeftDPad => m_Wrapper.m_APlayerMovement_LeftDPad;
        public InputAction @LeftBumperHold => m_Wrapper.m_APlayerMovement_LeftBumperHold;
        public InputActionMap Get() { return m_Wrapper.m_APlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(APlayerMovementActions set) { return set.Get(); }
        public void SetCallbacks(IAPlayerMovementActions instance)
        {
            if (m_Wrapper.m_APlayerMovementActionsCallbackInterface != null)
            {
                @LeftJoystickMovement.started -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnLeftJoystickMovement;
                @LeftJoystickMovement.performed -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnLeftJoystickMovement;
                @LeftJoystickMovement.canceled -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnLeftJoystickMovement;
                @RightJoystickMovement.started -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnRightJoystickMovement;
                @RightJoystickMovement.performed -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnRightJoystickMovement;
                @RightJoystickMovement.canceled -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnRightJoystickMovement;
                @AButtonPress.started -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnAButtonPress;
                @AButtonPress.performed -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnAButtonPress;
                @AButtonPress.canceled -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnAButtonPress;
                @XButtonHold.started -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnXButtonHold;
                @XButtonHold.performed -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnXButtonHold;
                @XButtonHold.canceled -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnXButtonHold;
                @RTButtonPress.started -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnRTButtonPress;
                @RTButtonPress.performed -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnRTButtonPress;
                @RTButtonPress.canceled -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnRTButtonPress;
                @BButtonPress.started -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnBButtonPress;
                @BButtonPress.performed -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnBButtonPress;
                @BButtonPress.canceled -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnBButtonPress;
                @RightDPad.started -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnRightDPad;
                @RightDPad.performed -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnRightDPad;
                @RightDPad.canceled -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnRightDPad;
                @LeftDPad.started -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnLeftDPad;
                @LeftDPad.performed -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnLeftDPad;
                @LeftDPad.canceled -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnLeftDPad;
                @LeftBumperHold.started -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnLeftBumperHold;
                @LeftBumperHold.performed -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnLeftBumperHold;
                @LeftBumperHold.canceled -= m_Wrapper.m_APlayerMovementActionsCallbackInterface.OnLeftBumperHold;
            }
            m_Wrapper.m_APlayerMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftJoystickMovement.started += instance.OnLeftJoystickMovement;
                @LeftJoystickMovement.performed += instance.OnLeftJoystickMovement;
                @LeftJoystickMovement.canceled += instance.OnLeftJoystickMovement;
                @RightJoystickMovement.started += instance.OnRightJoystickMovement;
                @RightJoystickMovement.performed += instance.OnRightJoystickMovement;
                @RightJoystickMovement.canceled += instance.OnRightJoystickMovement;
                @AButtonPress.started += instance.OnAButtonPress;
                @AButtonPress.performed += instance.OnAButtonPress;
                @AButtonPress.canceled += instance.OnAButtonPress;
                @XButtonHold.started += instance.OnXButtonHold;
                @XButtonHold.performed += instance.OnXButtonHold;
                @XButtonHold.canceled += instance.OnXButtonHold;
                @RTButtonPress.started += instance.OnRTButtonPress;
                @RTButtonPress.performed += instance.OnRTButtonPress;
                @RTButtonPress.canceled += instance.OnRTButtonPress;
                @BButtonPress.started += instance.OnBButtonPress;
                @BButtonPress.performed += instance.OnBButtonPress;
                @BButtonPress.canceled += instance.OnBButtonPress;
                @RightDPad.started += instance.OnRightDPad;
                @RightDPad.performed += instance.OnRightDPad;
                @RightDPad.canceled += instance.OnRightDPad;
                @LeftDPad.started += instance.OnLeftDPad;
                @LeftDPad.performed += instance.OnLeftDPad;
                @LeftDPad.canceled += instance.OnLeftDPad;
                @LeftBumperHold.started += instance.OnLeftBumperHold;
                @LeftBumperHold.performed += instance.OnLeftBumperHold;
                @LeftBumperHold.canceled += instance.OnLeftBumperHold;
            }
        }
    }
    public APlayerMovementActions @APlayerMovement => new APlayerMovementActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_LeftStickMove;
    private readonly InputAction m_UI_AButtonPress;
    private readonly InputAction m_UI_DPadMove;
    public struct UIActions
    {
        private @PlayerControls m_Wrapper;
        public UIActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftStickMove => m_Wrapper.m_UI_LeftStickMove;
        public InputAction @AButtonPress => m_Wrapper.m_UI_AButtonPress;
        public InputAction @DPadMove => m_Wrapper.m_UI_DPadMove;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @LeftStickMove.started -= m_Wrapper.m_UIActionsCallbackInterface.OnLeftStickMove;
                @LeftStickMove.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnLeftStickMove;
                @LeftStickMove.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnLeftStickMove;
                @AButtonPress.started -= m_Wrapper.m_UIActionsCallbackInterface.OnAButtonPress;
                @AButtonPress.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnAButtonPress;
                @AButtonPress.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnAButtonPress;
                @DPadMove.started -= m_Wrapper.m_UIActionsCallbackInterface.OnDPadMove;
                @DPadMove.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnDPadMove;
                @DPadMove.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnDPadMove;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftStickMove.started += instance.OnLeftStickMove;
                @LeftStickMove.performed += instance.OnLeftStickMove;
                @LeftStickMove.canceled += instance.OnLeftStickMove;
                @AButtonPress.started += instance.OnAButtonPress;
                @AButtonPress.performed += instance.OnAButtonPress;
                @AButtonPress.canceled += instance.OnAButtonPress;
                @DPadMove.started += instance.OnDPadMove;
                @DPadMove.performed += instance.OnDPadMove;
                @DPadMove.canceled += instance.OnDPadMove;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IAPlayerMovementActions
    {
        void OnLeftJoystickMovement(InputAction.CallbackContext context);
        void OnRightJoystickMovement(InputAction.CallbackContext context);
        void OnAButtonPress(InputAction.CallbackContext context);
        void OnXButtonHold(InputAction.CallbackContext context);
        void OnRTButtonPress(InputAction.CallbackContext context);
        void OnBButtonPress(InputAction.CallbackContext context);
        void OnRightDPad(InputAction.CallbackContext context);
        void OnLeftDPad(InputAction.CallbackContext context);
        void OnLeftBumperHold(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnLeftStickMove(InputAction.CallbackContext context);
        void OnAButtonPress(InputAction.CallbackContext context);
        void OnDPadMove(InputAction.CallbackContext context);
    }
}
