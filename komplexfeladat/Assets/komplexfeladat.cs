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
            ""name"": ""Player 1"",
            ""id"": ""2f3b87a7-9504-4a02-8ec7-e7fb9150ed1d"",
            ""actions"": [
                {
                    ""name"": ""Mozgo"",
                    ""type"": ""Value"",
                    ""id"": ""8f36b487-5a67-4b4e-a10a-c22b1a6d4057"",
                    ""expectedControlType"": ""Vector2"",
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
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mozgo"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0ce0194e-8a87-41fc-849f-23d9b1d46a8a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mozgo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d84702d5-20ad-4e93-9de3-29b5c3f6a335"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mozgo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7f09f7cd-e464-4f1e-b4ce-96f89014d985"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mozgo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5584b268-32df-4507-9b54-080d74ded3fd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mozgo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c52f7b08-5cb1-4ea6-9a24-892821c082b2"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
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
                    ""groups"": ""Keyboard&Mouse"",
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
                    ""groups"": ""Keyboard&Mouse"",
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
                    ""groups"": ""Keyboard&Mouse"",
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
        }
    ]
}");
        // Player 1
        m_Player1 = asset.FindActionMap("Player 1", throwIfNotFound: true);
        m_Player1_Mozgo = m_Player1.FindAction("Mozgo", throwIfNotFound: true);
        m_Player1_Ugras = m_Player1.FindAction("Ugras", throwIfNotFound: true);
        m_Player1_Dash = m_Player1.FindAction("Dash", throwIfNotFound: true);
        m_Player1_Shooting = m_Player1.FindAction("Shooting", throwIfNotFound: true);
        m_Player1_SwitchWeapon = m_Player1.FindAction("Switch Weapon", throwIfNotFound: true);
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

    // Player 1
    private readonly InputActionMap m_Player1;
    private IPlayer1Actions m_Player1ActionsCallbackInterface;
    private readonly InputAction m_Player1_Mozgo;
    private readonly InputAction m_Player1_Ugras;
    private readonly InputAction m_Player1_Dash;
    private readonly InputAction m_Player1_Shooting;
    private readonly InputAction m_Player1_SwitchWeapon;
    public struct Player1Actions
    {
        private @Komplexfeladat m_Wrapper;
        public Player1Actions(@Komplexfeladat wrapper) { m_Wrapper = wrapper; }
        public InputAction @Mozgo => m_Wrapper.m_Player1_Mozgo;
        public InputAction @Ugras => m_Wrapper.m_Player1_Ugras;
        public InputAction @Dash => m_Wrapper.m_Player1_Dash;
        public InputAction @Shooting => m_Wrapper.m_Player1_Shooting;
        public InputAction @SwitchWeapon => m_Wrapper.m_Player1_SwitchWeapon;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
            {
                @Mozgo.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMozgo;
                @Mozgo.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMozgo;
                @Mozgo.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMozgo;
                @Ugras.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnUgras;
                @Ugras.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnUgras;
                @Ugras.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnUgras;
                @Dash.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDash;
                @Shooting.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnShooting;
                @Shooting.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnShooting;
                @Shooting.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnShooting;
                @SwitchWeapon.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnSwitchWeapon;
                @SwitchWeapon.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnSwitchWeapon;
                @SwitchWeapon.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnSwitchWeapon;
            }
            m_Wrapper.m_Player1ActionsCallbackInterface = instance;
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
    public Player1Actions @Player1 => new Player1Actions(this);
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
    public interface IPlayer1Actions
    {
        void OnMozgo(InputAction.CallbackContext context);
        void OnUgras(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnShooting(InputAction.CallbackContext context);
        void OnSwitchWeapon(InputAction.CallbackContext context);
    }
}
