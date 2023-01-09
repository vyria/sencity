using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace BNG {

    [CustomEditor(typeof(Climbable))]
    [CanEditMultipleObjects]
    public class ClimbableEditor : Editor {

        /// <summary>
        /// Set this to false if you don't want to use the custom editor :)
        /// </summary>
        public bool UseCustomEditor = true;
        private Climbable climbable;
        private SerializedProperty grabButton;
        private SerializedProperty grabType;
        private SerializedProperty grabPhysics;
        private SerializedProperty grabMechanic;
        private SerializedProperty grabSpeed;
        private SerializedProperty remoteGrabbable;
        private SerializedProperty remoteGrabDistance;
        private SerializedProperty throwForceMultiplier;
        private SerializedProperty throwForceMultiplierAngular;
        private SerializedProperty breakDistance;
        private SerializedProperty hideHandGraphics;
        private SerializedProperty parentToHands;
        private SerializedProperty parentHandModel;
        private SerializedProperty snapHandModel;
        private SerializedProperty canBeDropped;
        private SerializedProperty CanBeSnappedToSnapZone;
        private SerializedProperty ForceDisableKinematicOnDrop;
        private SerializedProperty CustomHandPose;
        private SerializedProperty SecondaryGrabBehavior;
        private SerializedProperty OtherGrabbableMustBeGrabbed;
        private SerializedProperty SecondaryGrabbable;
        private SerializedProperty SecondHandLookSpeed;
        private SerializedProperty CollisionSpring;
        private SerializedProperty CollisionSlerp;
        private SerializedProperty CollisionLinearMotionX;
        private SerializedProperty CollisionLinearMotionY;
        private SerializedProperty CollisionLinearMotionZ;
        private SerializedProperty CollisionAngularMotionX;
        private SerializedProperty CollisionAngularMotionY;
        private SerializedProperty CollisionAngularMotionZ;
        private SerializedProperty ApplyCorrectiveForce;
        private SerializedProperty MoveVelocityForce;
        private SerializedProperty MoveAngularVelocityForce;
        private SerializedProperty GrabPoints;
        private SerializedProperty collisions;

        private void OnEnable() {
            grabButton = serializedObject.FindProperty("GrabButton");
            grabType = serializedObject.FindProperty("Grabtype");
            grabPhysics = serializedObject.FindProperty("GrabPhysics");
            grabMechanic = serializedObject.FindProperty("GrabMechanic");
            grabSpeed = serializedObject.FindProperty("GrabSpeed");
            remoteGrabbable = serializedObject.FindProperty("RemoteGrabbable");
            remoteGrabDistance = serializedObject.FindProperty("RemoteGrabDistance");
            throwForceMultiplier = serializedObject.FindProperty("ThrowForceMultiplier");
            throwForceMultiplierAngular = serializedObject.FindProperty("ThrowForceMultiplierAngular");
            breakDistance = serializedObject.FindProperty("BreakDistance");
            hideHandGraphics = serializedObject.FindProperty("HideHandGraphics");
            parentToHands = serializedObject.FindProperty("ParentToHands");
            parentHandModel = serializedObject.FindProperty("ParentHandModel");
            snapHandModel = serializedObject.FindProperty("SnapHandModel");
            canBeDropped = serializedObject.FindProperty("CanBeDropped");
            CanBeSnappedToSnapZone = serializedObject.FindProperty("CanBeSnappedToSnapZone");
            ForceDisableKinematicOnDrop = serializedObject.FindProperty("ForceDisableKinematicOnDrop");
            CustomHandPose = serializedObject.FindProperty("CustomHandPose");
            SecondaryGrabBehavior = serializedObject.FindProperty("SecondaryGrabBehavior");
            OtherGrabbableMustBeGrabbed = serializedObject.FindProperty("OtherGrabbableMustBeGrabbed");
            SecondaryGrabbable = serializedObject.FindProperty("SecondaryGrabbable");
            SecondHandLookSpeed = serializedObject.FindProperty("SecondHandLookSpeed");
            CollisionSpring = serializedObject.FindProperty("CollisionSpring");
            CollisionSlerp = serializedObject.FindProperty("CollisionSlerp");
            CollisionLinearMotionX = serializedObject.FindProperty("CollisionLinearMotionX");
            CollisionLinearMotionY = serializedObject.FindProperty("CollisionLinearMotionY");
            CollisionLinearMotionZ = serializedObject.FindProperty("CollisionLinearMotionZ");
            CollisionAngularMotionX = serializedObject.FindProperty("CollisionAngularMotionX");
            CollisionAngularMotionY = serializedObject.FindProperty("CollisionAngularMotionY");
            CollisionAngularMotionZ = serializedObject.FindProperty("CollisionAngularMotionZ");
            ApplyCorrectiveForce = serializedObject.FindProperty("ApplyCorrectiveForce");
            MoveVelocityForce = serializedObject.FindProperty("MoveVelocityForce");
            MoveAngularVelocityForce = serializedObject.FindProperty("MoveAngularVelocityForce");
            GrabPoints = serializedObject.FindProperty("GrabPoints");
            collisions = serializedObject.FindProperty("collisions");
        }

        public override void OnInspectorGUI() {

            climbable = (Climbable)target;

            // Don't use Custom Editor
            if (UseCustomEditor == false || climbable.UseCustomInspector == false) {
                base.OnInspectorGUI();
                return;
            }

            EditorGUILayout.PropertyField(grabButton);
            EditorGUILayout.PropertyField(grabType, new GUIContent("Grab Type"));
            EditorGUILayout.PropertyField(grabMechanic);

            EditorGUILayout.PropertyField(hideHandGraphics);
            EditorGUILayout.PropertyField(parentHandModel);
            EditorGUILayout.PropertyField(snapHandModel);

            EditorGUILayout.PropertyField(canBeDropped);           
            EditorGUILayout.PropertyField(CanBeSnappedToSnapZone);

            EditorGUILayout.PropertyField(breakDistance);

            EditorGUILayout.PropertyField(CustomHandPose);

            EditorGUILayout.PropertyField(GrabPoints);

            // Only show Debug Fields when playing in editor
            if (Application.isPlaying) {
                EditorGUILayout.PropertyField(collisions);
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}
