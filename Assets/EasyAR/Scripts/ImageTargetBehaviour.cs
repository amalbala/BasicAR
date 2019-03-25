//=============================================================================================================================
//
// Copyright (c) 2015-2017 VisionStar Information Technology (Shanghai) Co., Ltd. All Rights Reserved.
// EasyAR is the registered trademark or trademark of VisionStar Information Technology (Shanghai) Co., Ltd in China
// and other countries for the augmented reality technology developed by VisionStar Information Technology (Shanghai) Co., Ltd.
//
//=============================================================================================================================

using UnityEngine;

namespace EasyAR {
    public class ImageTargetBehaviour : ImageTargetBaseBehaviour {
        protected override void Awake() {
            base.Awake();
            TargetFound += OnTargetFound;
            TargetLost += OnTargetLost;
            TargetLoad += OnTargetLoad;
            TargetUnload += OnTargetUnload;

            void OnTargetFound(TargetAbstractBehaviour behaviour) {
                Debug.Log("Found: " + Target.Id);
            }

            void OnTargetLost(TargetAbstractBehaviour behaviour) {
                Debug.Log("Lost: " + Target.Id);
            }

            void OnTargetLoad(TargetAbstractBehaviour behaviour, ImageTrackerBaseBehaviour tracker, bool status) {
                Debug.Log("Load Target (" + status + "): " + Target.Id + " (" + Target.Name + ") " + "->" + tracker);
            }

            void OnTargetUnload(TargetAbstractBehaviour behaviour, ImageTrackerBaseBehaviour tracker, bool status) {
                Debug.Log("Load Target (" + status + "): " + Target.Id + " (" + Target.Name + ") " + "->" + tracker);
            }
        }
    }
}