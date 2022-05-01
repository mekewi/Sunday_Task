using System.Collections;
using System.Collections.Generic;
using EventsSystem.Scripts.Editor;
using ProjectArchitectureBase.BaseScriptsRuntime.Event;
using UnityEditor;
using UnityEngine;
namespace ProjectArchitectureBase.BaseScriptsRuntime.Editor
{
    [CustomEditor(typeof(Vector2Event))]
    public class Vector2EventEditor : EventEditorBase<Vector2,Vector2Event>
    {
    }
}
