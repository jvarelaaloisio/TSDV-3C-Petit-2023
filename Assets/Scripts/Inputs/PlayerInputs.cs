//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.0
//     from Assets/Inputs/PlayerInputs.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Inputs
{
    public partial class @PlayerInputs: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerInputs()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""World"",
            ""id"": ""a8bebb75-8115-4614-b4da-fd4b09f197c0"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""bd3f1893-5811-44ab-b6b4-c30cd759dceb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""6b083803-2410-4117-aa85-52d31b927e57"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Value"",
                    ""id"": ""eaccc77c-046a-4f7e-93e3-d318e95f1425"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""PassThrough"",
                    ""id"": ""362f24f4-e094-4a9e-9156-7af0e923ece4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Value"",
                    ""id"": ""ceb6dc37-e7be-4807-bda6-c022d0f1a677"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""63937264-6fc2-409c-b63d-698013ef1516"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""5c79b4cf-f8ae-46ad-871e-ffe6c8736a40"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CloseCanvas"",
                    ""type"": ""Value"",
                    ""id"": ""e520537e-a5c0-488f-a163-2f7669b3c265"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""db893c25-414c-4505-990d-f97980a9653c"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""406af9f7-908b-4272-8216-458808d1750d"",
                    ""path"": ""<DualShockGamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""dbe56936-cc91-4d07-9942-d5e3749da6db"",
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
                    ""id"": ""5569aee4-ddbf-4841-8af1-69eac1b78fcc"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3f4f574f-fffe-4dd4-8dfd-8423ec60cc4e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""155fa40e-5c87-42b0-9eb7-39b7c7a09596"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7201135e-5856-4709-bc94-473733d658b0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bf165a57-a399-4a5e-902e-b642fd4bee5e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b692af65-8fdb-4a8e-8755-2a085487d625"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20638013-d546-48fd-b9a2-33a55ee3c569"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9e5efc6-401b-4582-affd-5bc5ae1053fa"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6af9fda2-aa7c-491a-b4d9-70d6f17fbece"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""adc78dc0-271c-45c1-8fe2-63e1bc8d2965"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a59f45f4-0b88-43d8-ab1b-571c889593c0"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd87942e-0e6c-4e73-94af-d739bda272c8"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c2962b3f-2a96-49ef-a557-e79b7c158f22"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b628775f-3eb8-42df-8e84-4079a04637a6"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CloseCanvas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""df3c7c0d-6ff3-43b1-90ca-3c70085a46e4"",
            ""actions"": [
                {
                    ""name"": ""Selecction"",
                    ""type"": ""Button"",
                    ""id"": ""c6f21b5b-159c-4779-85a0-b559b4a4f3bc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Enter"",
                    ""type"": ""Button"",
                    ""id"": ""57f81f20-b748-4669-b850-e9cea2ddefd5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""9e7f86d3-8ee9-4ce9-b6ae-f9c4427fccc3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e6b9c1ae-0180-4fb1-b02c-f48a359c568c"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Enter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2f5e4630-98fc-4335-8b73-cbaa452fbfde"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""adddeda0-b4d1-4df6-b9b2-d6b4510946eb"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WS"",
                    ""id"": ""e303581f-aa4c-494a-bada-5dd0a5a4f752"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Selecction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1e49f56f-2398-4a91-acf4-5896772075d4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Selecction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a9860c30-e9f8-4290-ab58-6a1d1f0558e4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Selecction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""4ff3f607-eb37-4b80-bd88-c950aab0ad46"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Selecction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0e8ef473-f66f-4c42-859b-b82739e9e7c3"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Selecction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""13d72db0-2c14-4d5f-99d4-70e79f2aade5"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Selecction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // World
            m_World = asset.FindActionMap("World", throwIfNotFound: true);
            m_World_Move = m_World.FindAction("Move", throwIfNotFound: true);
            m_World_Jump = m_World.FindAction("Jump", throwIfNotFound: true);
            m_World_Sprint = m_World.FindAction("Sprint", throwIfNotFound: true);
            m_World_Camera = m_World.FindAction("Camera", throwIfNotFound: true);
            m_World_Shoot = m_World.FindAction("Shoot", throwIfNotFound: true);
            m_World_Aim = m_World.FindAction("Aim", throwIfNotFound: true);
            m_World_Reload = m_World.FindAction("Reload", throwIfNotFound: true);
            m_World_CloseCanvas = m_World.FindAction("CloseCanvas", throwIfNotFound: true);
            // Menu
            m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
            m_Menu_Selecction = m_Menu.FindAction("Selecction", throwIfNotFound: true);
            m_Menu_Enter = m_Menu.FindAction("Enter", throwIfNotFound: true);
            m_Menu_Back = m_Menu.FindAction("Back", throwIfNotFound: true);
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

        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }

        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // World
        private readonly InputActionMap m_World;
        private List<IWorldActions> m_WorldActionsCallbackInterfaces = new List<IWorldActions>();
        private readonly InputAction m_World_Move;
        private readonly InputAction m_World_Jump;
        private readonly InputAction m_World_Sprint;
        private readonly InputAction m_World_Camera;
        private readonly InputAction m_World_Shoot;
        private readonly InputAction m_World_Aim;
        private readonly InputAction m_World_Reload;
        private readonly InputAction m_World_CloseCanvas;
        public struct WorldActions
        {
            private @PlayerInputs m_Wrapper;
            public WorldActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_World_Move;
            public InputAction @Jump => m_Wrapper.m_World_Jump;
            public InputAction @Sprint => m_Wrapper.m_World_Sprint;
            public InputAction @Camera => m_Wrapper.m_World_Camera;
            public InputAction @Shoot => m_Wrapper.m_World_Shoot;
            public InputAction @Aim => m_Wrapper.m_World_Aim;
            public InputAction @Reload => m_Wrapper.m_World_Reload;
            public InputAction @CloseCanvas => m_Wrapper.m_World_CloseCanvas;
            public InputActionMap Get() { return m_Wrapper.m_World; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(WorldActions set) { return set.Get(); }
            public void AddCallbacks(IWorldActions instance)
            {
                if (instance == null || m_Wrapper.m_WorldActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_WorldActionsCallbackInterfaces.Add(instance);
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
                @CloseCanvas.started += instance.OnCloseCanvas;
                @CloseCanvas.performed += instance.OnCloseCanvas;
                @CloseCanvas.canceled += instance.OnCloseCanvas;
            }

            private void UnregisterCallbacks(IWorldActions instance)
            {
                @Move.started -= instance.OnMove;
                @Move.performed -= instance.OnMove;
                @Move.canceled -= instance.OnMove;
                @Jump.started -= instance.OnJump;
                @Jump.performed -= instance.OnJump;
                @Jump.canceled -= instance.OnJump;
                @Sprint.started -= instance.OnSprint;
                @Sprint.performed -= instance.OnSprint;
                @Sprint.canceled -= instance.OnSprint;
                @Camera.started -= instance.OnCamera;
                @Camera.performed -= instance.OnCamera;
                @Camera.canceled -= instance.OnCamera;
                @Shoot.started -= instance.OnShoot;
                @Shoot.performed -= instance.OnShoot;
                @Shoot.canceled -= instance.OnShoot;
                @Aim.started -= instance.OnAim;
                @Aim.performed -= instance.OnAim;
                @Aim.canceled -= instance.OnAim;
                @Reload.started -= instance.OnReload;
                @Reload.performed -= instance.OnReload;
                @Reload.canceled -= instance.OnReload;
                @CloseCanvas.started -= instance.OnCloseCanvas;
                @CloseCanvas.performed -= instance.OnCloseCanvas;
                @CloseCanvas.canceled -= instance.OnCloseCanvas;
            }

            public void RemoveCallbacks(IWorldActions instance)
            {
                if (m_Wrapper.m_WorldActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IWorldActions instance)
            {
                foreach (var item in m_Wrapper.m_WorldActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_WorldActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public WorldActions @World => new WorldActions(this);

        // Menu
        private readonly InputActionMap m_Menu;
        private List<IMenuActions> m_MenuActionsCallbackInterfaces = new List<IMenuActions>();
        private readonly InputAction m_Menu_Selecction;
        private readonly InputAction m_Menu_Enter;
        private readonly InputAction m_Menu_Back;
        public struct MenuActions
        {
            private @PlayerInputs m_Wrapper;
            public MenuActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @Selecction => m_Wrapper.m_Menu_Selecction;
            public InputAction @Enter => m_Wrapper.m_Menu_Enter;
            public InputAction @Back => m_Wrapper.m_Menu_Back;
            public InputActionMap Get() { return m_Wrapper.m_Menu; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
            public void AddCallbacks(IMenuActions instance)
            {
                if (instance == null || m_Wrapper.m_MenuActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_MenuActionsCallbackInterfaces.Add(instance);
                @Selecction.started += instance.OnSelecction;
                @Selecction.performed += instance.OnSelecction;
                @Selecction.canceled += instance.OnSelecction;
                @Enter.started += instance.OnEnter;
                @Enter.performed += instance.OnEnter;
                @Enter.canceled += instance.OnEnter;
                @Back.started += instance.OnBack;
                @Back.performed += instance.OnBack;
                @Back.canceled += instance.OnBack;
            }

            private void UnregisterCallbacks(IMenuActions instance)
            {
                @Selecction.started -= instance.OnSelecction;
                @Selecction.performed -= instance.OnSelecction;
                @Selecction.canceled -= instance.OnSelecction;
                @Enter.started -= instance.OnEnter;
                @Enter.performed -= instance.OnEnter;
                @Enter.canceled -= instance.OnEnter;
                @Back.started -= instance.OnBack;
                @Back.performed -= instance.OnBack;
                @Back.canceled -= instance.OnBack;
            }

            public void RemoveCallbacks(IMenuActions instance)
            {
                if (m_Wrapper.m_MenuActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IMenuActions instance)
            {
                foreach (var item in m_Wrapper.m_MenuActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_MenuActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public MenuActions @Menu => new MenuActions(this);
        public interface IWorldActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnSprint(InputAction.CallbackContext context);
            void OnCamera(InputAction.CallbackContext context);
            void OnShoot(InputAction.CallbackContext context);
            void OnAim(InputAction.CallbackContext context);
            void OnReload(InputAction.CallbackContext context);
            void OnCloseCanvas(InputAction.CallbackContext context);
        }
        public interface IMenuActions
        {
            void OnSelecction(InputAction.CallbackContext context);
            void OnEnter(InputAction.CallbackContext context);
            void OnBack(InputAction.CallbackContext context);
        }
    }
}
