// GENERATED AUTOMATICALLY FROM 'Assets/vfxMidi.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @VfxMidi : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @VfxMidi()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""vfxMidi"",
    ""maps"": [
        {
            ""name"": ""Leaves"",
            ""id"": ""af98e917-c8d1-4bb3-af25-f23ae92f74fd"",
            ""actions"": [
                {
                    ""name"": ""triggerTop"",
                    ""type"": ""Button"",
                    ""id"": ""ef4709e8-86d1-4741-a24f-5659c6085c52"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""triggerBottom"",
                    ""type"": ""Button"",
                    ""id"": ""c8006d3b-c3f7-4f5c-811b-2146a80803e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fader"",
                    ""type"": ""Value"",
                    ""id"": ""6a570be1-9452-495b-b2da-d5b0e33fc09e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""57e3e42c-052c-4cc8-9754-44fe9b2788f5"",
                    ""path"": ""<MidiDevice>/note041"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""triggerTop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2eed2ba3-6ebb-4413-a306-9841d12c55b0"",
                    ""path"": ""<MidiDevice>/note073"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""triggerBottom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e231575-caad-4c60-91f6-72489e963d46"",
                    ""path"": ""<MidiDevice>/control077"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Fader"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""camera"",
            ""id"": ""766614e4-9198-426a-beeb-29cdf7046f74"",
            ""actions"": [
                {
                    ""name"": ""cameraZ"",
                    ""type"": ""Value"",
                    ""id"": ""98d157a3-2e07-4746-a17b-aeb4e0fbf669"",
                    ""expectedControlType"": ""MidiValue"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3744cfd0-4067-4163-a55c-a609161a2215"",
                    ""path"": ""<MidiDevice>/control020"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""cameraZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""New control scheme"",
            ""bindingGroup"": ""New control scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<MidiDevice>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Leaves
        m_Leaves = asset.FindActionMap("Leaves", throwIfNotFound: true);
        m_Leaves_triggerTop = m_Leaves.FindAction("triggerTop", throwIfNotFound: true);
        m_Leaves_triggerBottom = m_Leaves.FindAction("triggerBottom", throwIfNotFound: true);
        m_Leaves_Fader = m_Leaves.FindAction("Fader", throwIfNotFound: true);
        // camera
        m_camera = asset.FindActionMap("camera", throwIfNotFound: true);
        m_camera_cameraZ = m_camera.FindAction("cameraZ", throwIfNotFound: true);
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

    // Leaves
    private readonly InputActionMap m_Leaves;
    private ILeavesActions m_LeavesActionsCallbackInterface;
    private readonly InputAction m_Leaves_triggerTop;
    private readonly InputAction m_Leaves_triggerBottom;
    private readonly InputAction m_Leaves_Fader;
    public struct LeavesActions
    {
        private @VfxMidi m_Wrapper;
        public LeavesActions(@VfxMidi wrapper) { m_Wrapper = wrapper; }
        public InputAction @triggerTop => m_Wrapper.m_Leaves_triggerTop;
        public InputAction @triggerBottom => m_Wrapper.m_Leaves_triggerBottom;
        public InputAction @Fader => m_Wrapper.m_Leaves_Fader;
        public InputActionMap Get() { return m_Wrapper.m_Leaves; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LeavesActions set) { return set.Get(); }
        public void SetCallbacks(ILeavesActions instance)
        {
            if (m_Wrapper.m_LeavesActionsCallbackInterface != null)
            {
                @triggerTop.started -= m_Wrapper.m_LeavesActionsCallbackInterface.OnTriggerTop;
                @triggerTop.performed -= m_Wrapper.m_LeavesActionsCallbackInterface.OnTriggerTop;
                @triggerTop.canceled -= m_Wrapper.m_LeavesActionsCallbackInterface.OnTriggerTop;
                @triggerBottom.started -= m_Wrapper.m_LeavesActionsCallbackInterface.OnTriggerBottom;
                @triggerBottom.performed -= m_Wrapper.m_LeavesActionsCallbackInterface.OnTriggerBottom;
                @triggerBottom.canceled -= m_Wrapper.m_LeavesActionsCallbackInterface.OnTriggerBottom;
                @Fader.started -= m_Wrapper.m_LeavesActionsCallbackInterface.OnFader;
                @Fader.performed -= m_Wrapper.m_LeavesActionsCallbackInterface.OnFader;
                @Fader.canceled -= m_Wrapper.m_LeavesActionsCallbackInterface.OnFader;
            }
            m_Wrapper.m_LeavesActionsCallbackInterface = instance;
            if (instance != null)
            {
                @triggerTop.started += instance.OnTriggerTop;
                @triggerTop.performed += instance.OnTriggerTop;
                @triggerTop.canceled += instance.OnTriggerTop;
                @triggerBottom.started += instance.OnTriggerBottom;
                @triggerBottom.performed += instance.OnTriggerBottom;
                @triggerBottom.canceled += instance.OnTriggerBottom;
                @Fader.started += instance.OnFader;
                @Fader.performed += instance.OnFader;
                @Fader.canceled += instance.OnFader;
            }
        }
    }
    public LeavesActions @Leaves => new LeavesActions(this);

    // camera
    private readonly InputActionMap m_camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_camera_cameraZ;
    public struct CameraActions
    {
        private @VfxMidi m_Wrapper;
        public CameraActions(@VfxMidi wrapper) { m_Wrapper = wrapper; }
        public InputAction @cameraZ => m_Wrapper.m_camera_cameraZ;
        public InputActionMap Get() { return m_Wrapper.m_camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @cameraZ.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnCameraZ;
                @cameraZ.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnCameraZ;
                @cameraZ.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnCameraZ;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @cameraZ.started += instance.OnCameraZ;
                @cameraZ.performed += instance.OnCameraZ;
                @cameraZ.canceled += instance.OnCameraZ;
            }
        }
    }
    public CameraActions @camera => new CameraActions(this);
    private int m_NewcontrolschemeSchemeIndex = -1;
    public InputControlScheme NewcontrolschemeScheme
    {
        get
        {
            if (m_NewcontrolschemeSchemeIndex == -1) m_NewcontrolschemeSchemeIndex = asset.FindControlSchemeIndex("New control scheme");
            return asset.controlSchemes[m_NewcontrolschemeSchemeIndex];
        }
    }
    public interface ILeavesActions
    {
        void OnTriggerTop(InputAction.CallbackContext context);
        void OnTriggerBottom(InputAction.CallbackContext context);
        void OnFader(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnCameraZ(InputAction.CallbackContext context);
    }
}
