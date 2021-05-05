// GENERATED AUTOMATICALLY FROM 'Assets/komplexfeladat.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Komplexfeladat : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Komplexfeladat()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""komplexfeladat"",
    ""maps"": [
        {
            ""name"": ""Player Move"",
            ""id"": ""2f3b87a7-9504-4a02-8ec7-e7fb9150ed1d"",
            ""actions"": [
                {
                    ""name"": ""Mozgo"",
                    ""type"": ""Value"",
                    ""id"": ""8f36b487-5a67-4b4e-a10a-c22b1a6d4057"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ugras"",
                    ""type"": ""Button"",
                    ""id"": ""23194fa5-f773-424b-beee-67eac9951d7c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""4cce602a-1ccb-4247-ba7f-51defce8f349"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shooting"",
                    ""type"": ""Button"",
                    ""id"": ""1094591a-5701-4b93-94dc-ae17e3549bad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Switch Weapon"",
                    ""type"": ""Button"",
                    ""id"": ""d5ff9a3b-4856-4f43-957c-904431ce724b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""cad1cf29-4e50-42ea-830f-7600696efb83"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mozgo"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""0ce0194e-8a87-41fc-849f-23d9b1d46a8a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player 1 Control"",
                    ""action"": ""Mozgo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""d84702d5-20ad-4e93-9de3-29b5c3f6a335"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player 1 Control"",
                    ""action"": ""Mozgo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Nyilak"",
                    ""id"": ""dc1eec53-5ae2-4ff2-83c9-56bba0f73601"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mozgo"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""689c46f6-a5b6-481d-bb49-463e661b0eeb"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player 2 Control"",
                    ""action"": ""Mozgo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""a01111a4-b375-43fc-bca2-70e78bf9bb17"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player 2 Control"",
                    ""action"": ""Mozgo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b8173464-0963-47ef-b08c-98c8d48a6905"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player 2 Control"",
                    ""action"": ""Mozgo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c52f7b08-5cb1-4ea6-9a24-892821c082b2"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player 1 Control"",
                    ""action"": ""Ugras"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad16c5f8-b9dc-4354-b081-3cc2533b48c8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player 1 Control"",
                    ""action"": ""Ugras"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""037e4543-40c2-42d8-9b27-473da306f78a"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player 2 Control"",
                    ""action"": ""Ugras"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""418cdaac-088d-4bfd-bc55-1a43d14c93d3"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player 2 Control"",
                    ""action"": ""Ugras"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""61311991-9072-490e-b79f-4d7a677e57ed"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player 1 Control"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6380dbc0-11da-4bf9-8fb2-631d6d5ebe39"",
                    ""path"": ""<Keyboard>/rightShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player 2 Control"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53783bbb-13ad-416a-a959-edf304297cd2"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player 2 Control"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d9b9ea5-31f7-4716-abd5-ce3e6df549bd"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player 1 Control"",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e912ff2f-38fe-4fee-9ed6-11d415634050"",
                    ""path"": ""<Keyboard>/rightCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player 2 Control"",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e85e872c-6038-46e4-a848-ed06d7864ee7"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player 2 Control"",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45800f21-50bd-4187-be09-1043fb08ac7b"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player 1 Control"",
                    ""action"": ""Switch Weapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86d0357f-dfa9-4f1e-9309-d4a5d56e916c"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player 2 Control"",
                    ""action"": ""Switch Weapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0faaf6d4-3f9e-49d0-900d-a1c587746fb0"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player 2 Control"",
                    ""action"": ""Switch Weapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Player 2 Control"",
            ""bindingGroup"": ""Player 2 Control"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Player 1 Control"",
            ""bindingGroup"": ""Player 1 Control"",
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
        // Player Move
        m_PlayerMove = asset.FindActionMap("Player Move", throwIfNotFound: true);
        m_PlayerMove_Mozgo = m_PlayerMove.FindAction("Mozgo", throwIfNotFound: true);
        m_PlayerMove_Ugras = m_PlayerMove.FindAction("Ugras", throwIfNotFound: true);
        m_PlayerMove_Dash = m_PlayerMove.FindAction("Dash", throwIfNotFound: true);
        m_PlayerMove_Shooting = m_PlayerMove.FindAction("Shooting", throwIfNotFound: true);
        m_PlayerMove_SwitchWeapon = m_PlayerMove.FindAction("Switch Weapon", throwIfNotFound: true);
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

    // Player Move
    private readonly InputActionMap m_PlayerMove;
    private IPlayerMoveActions m_PlayerMoveActionsCallbackInterface;
    private readonly InputAction m_PlayerMove_Mozgo;
    private readonly InputAction m_PlayerMove_Ugras;
    private readonly InputAction m_PlayerMove_Dash;
    private readonly InputAction m_PlayerMove_Shooting;
    private readonly InputAction m_PlayerMove_SwitchWeapon;
    public struct PlayerMoveActions
    {
        private @Komplexfeladat m_Wrapper;
        public PlayerMoveActions(@Komplexfeladat wrapper) { m_Wrapper = wrapper; }
        public InputAction @Mozgo => m_Wrapper.m_PlayerMove_Mozgo;
        public InputAction @Ugras => m_Wrapper.m_PlayerMove_Ugras;
        public InputAction @Dash => m_Wrapper.m_PlayerMove_Dash;
        public InputAction @Shooting => m_Wrapper.m_PlayerMove_Shooting;
        public InputAction @SwitchWeapon => m_Wrapper.m_PlayerMove_SwitchWeapon;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMove; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMoveActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMoveActions instance)
        {
            if (m_Wrapper.m_PlayerMoveActionsCallbackInterface != null)
            {
                @Mozgo.started -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnMozgo;
                @Mozgo.performed -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnMozgo;
                @Mozgo.canceled -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnMozgo;
                @Ugras.started -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnUgras;
                @Ugras.performed -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnUgras;
                @Ugras.canceled -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnUgras;
                @Dash.started -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnDash;
                @Shooting.started -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnShooting;
                @Shooting.performed -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnShooting;
                @Shooting.canceled -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnShooting;
                @SwitchWeapon.started -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnSwitchWeapon;
                @SwitchWeapon.performed -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnSwitchWeapon;
                @SwitchWeapon.canceled -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnSwitchWeapon;
            }
            m_Wrapper.m_PlayerMoveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Mozgo.started += instance.OnMozgo;
                @Mozgo.performed += instance.OnMozgo;
                @Mozgo.canceled += instance.OnMozgo;
                @Ugras.started += instance.OnUgras;
                @Ugras.performed += instance.OnUgras;
                @Ugras.canceled += instance.OnUgras;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @Shooting.started += instance.OnShooting;
                @Shooting.performed += instance.OnShooting;
                @Shooting.canceled += instance.OnShooting;
                @SwitchWeapon.started += instance.OnSwitchWeapon;
                @SwitchWeapon.performed += instance.OnSwitchWeapon;
                @SwitchWeapon.canceled += instance.OnSwitchWeapon;
            }
        }
    }
    public PlayerMoveActions @PlayerMove => new PlayerMoveActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    private int m_Player2ControlSchemeIndex = -1;
    public InputControlScheme Player2ControlScheme
    {
        get
        {
            if (m_Player2ControlSchemeIndex == -1) m_Player2ControlSchemeIndex = asset.FindControlSchemeIndex("Player 2 Control");
            return asset.controlSchemes[m_Player2ControlSchemeIndex];
        }
    }
    private int m_Player1ControlSchemeIndex = -1;
    public InputControlScheme Player1ControlScheme
    {
        get
        {
            if (m_Player1ControlSchemeIndex == -1) m_Player1ControlSchemeIndex = asset.FindControlSchemeIndex("Player 1 Control");
            return asset.controlSchemes[m_Player1ControlSchemeIndex];
        }
    }
    public interface IPlayerMoveActions
    {
        void OnMozgo(InputAction.CallbackContext context);
        void OnUgras(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnShooting(InputAction.CallbackContext context);
        void OnSwitchWeapon(InputAction.CallbackContext context);
    }
}
