﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BNG {
    public class VRTextInput : MonoBehaviour {
        private UnityEngine.UI.InputField thisInputField;

        public bool AttachToVRKeyboard = true;

        public bool ActivateKeyboardOnSelect = true;
        public bool DeactivateKeyboardOnDeselect = false;

        public VRKeyboard AttachedKeyboard;
        private bool isFocused, wasFocused = false;

        private void Awake() {
            thisInputField = GetComponent<UnityEngine.UI.InputField>();
            
            if(thisInputField && AttachedKeyboard != null) {
                AttachedKeyboard.AttachToInputField(thisInputField);
            }
        }

        private void Update() {

            isFocused = thisInputField != null && thisInputField.isFocused;

            // Check if our input field is now focused
            if(isFocused == true && wasFocused == false) {
                OnInputSelect();
            }
            else if (isFocused == false && wasFocused == true) {
                OnInputDeselect();
            }

            wasFocused = isFocused;
        }

        public void OnInputSelect() {

            // Enable keyboard if disabled
            if (ActivateKeyboardOnSelect && AttachedKeyboard != null && !AttachedKeyboard.gameObject.activeInHierarchy) {
                AttachedKeyboard.gameObject.SetActive(true);

                AttachedKeyboard.AttachToInputField(thisInputField);
            }
        }

        public void OnInputDeselect() {
            if (DeactivateKeyboardOnDeselect && AttachedKeyboard != null && AttachedKeyboard.gameObject.activeInHierarchy) {
                AttachedKeyboard.gameObject.SetActive(false);
            }
        }

        // Assign the AttachedKeyboard variable when adding the component to a GameObject for the first time
        private void Reset() {
            var keyboard = GameObject.FindObjectOfType<VRKeyboard>();
            if(keyboard) {
                AttachedKeyboard = keyboard;
                Debug.Log("Found and attached Keyboard to " + AttachedKeyboard.transform.name);
            }
        }
    }
}


