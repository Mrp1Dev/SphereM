// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputMap.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMap : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMap()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMap"",
    ""maps"": [
        {
            ""name"": ""Default-Sphere"",
            ""id"": ""319c3550-f821-47c6-b57b-8fc9180e163f"",
            ""actions"": [
                {
                    ""name"": ""Steer"",
                    ""type"": ""Value"",
                    ""id"": ""44866013-3dbc-4296-9089-4602e2523198"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Drift"",
                    ""type"": ""Value"",
                    ""id"": ""0ca1b5ed-00ea-4d2c-ac42-e6e1ef9519fa"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""98e1996f-0796-4192-b6f4-eed4d7491e37"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ba212cc3-c04d-4338-bfed-4cd0331e5733"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""603e3079-b601-495d-9d3f-f2edd87b36f3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""51de4dbc-356e-47ef-9e06-229bb219b0f1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7ca84ba3-6d19-4dfa-b88f-1e5d8955e03c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""25784365-fb69-4ccf-978b-5d6410cdfb78"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Xbox"",
                    ""id"": ""ed1538ab-6948-428b-882a-96bafb99fb1d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""37c02138-1fcd-4271-9bc7-6be6afba070e"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0a979df0-a7c5-48bc-869f-ef0e2c8c9fd0"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""07932fb0-20bc-44a8-8d76-1bc447ec9b68"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d038d223-39a2-4549-a75c-566a6238f73d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d658c30-4e9d-40a1-b881-24a00853a554"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd95621e-6bfb-4bf6-8000-65344b4dada2"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""953d5261-8d54-45f8-a7ab-637f6ea758d8"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Default-Sphere
        m_DefaultSphere = asset.FindActionMap("Default-Sphere", throwIfNotFound: true);
        m_DefaultSphere_Steer = m_DefaultSphere.FindAction("Steer", throwIfNotFound: true);
        m_DefaultSphere_Drift = m_DefaultSphere.FindAction("Drift", throwIfNotFound: true);
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

    // Default-Sphere
    private readonly InputActionMap m_DefaultSphere;
    private IDefaultSphereActions m_DefaultSphereActionsCallbackInterface;
    private readonly InputAction m_DefaultSphere_Steer;
    private readonly InputAction m_DefaultSphere_Drift;
    public struct DefaultSphereActions
    {
        private @InputMap m_Wrapper;
        public DefaultSphereActions(@InputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Steer => m_Wrapper.m_DefaultSphere_Steer;
        public InputAction @Drift => m_Wrapper.m_DefaultSphere_Drift;
        public InputActionMap Get() { return m_Wrapper.m_DefaultSphere; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultSphereActions set) { return set.Get(); }
        public void SetCallbacks(IDefaultSphereActions instance)
        {
            if (m_Wrapper.m_DefaultSphereActionsCallbackInterface != null)
            {
                @Steer.started -= m_Wrapper.m_DefaultSphereActionsCallbackInterface.OnSteer;
                @Steer.performed -= m_Wrapper.m_DefaultSphereActionsCallbackInterface.OnSteer;
                @Steer.canceled -= m_Wrapper.m_DefaultSphereActionsCallbackInterface.OnSteer;
                @Drift.started -= m_Wrapper.m_DefaultSphereActionsCallbackInterface.OnDrift;
                @Drift.performed -= m_Wrapper.m_DefaultSphereActionsCallbackInterface.OnDrift;
                @Drift.canceled -= m_Wrapper.m_DefaultSphereActionsCallbackInterface.OnDrift;
            }
            m_Wrapper.m_DefaultSphereActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Steer.started += instance.OnSteer;
                @Steer.performed += instance.OnSteer;
                @Steer.canceled += instance.OnSteer;
                @Drift.started += instance.OnDrift;
                @Drift.performed += instance.OnDrift;
                @Drift.canceled += instance.OnDrift;
            }
        }
    }
    public DefaultSphereActions @DefaultSphere => new DefaultSphereActions(this);
    public interface IDefaultSphereActions
    {
        void OnSteer(InputAction.CallbackContext context);
        void OnDrift(InputAction.CallbackContext context);
    }
}
