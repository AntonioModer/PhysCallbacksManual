using UnityEngine;

public class PhysCallbacksManual : MonoBehaviour {
    int index;

    private void OnEnable() {
        Physics.ContactEvent += Physics_ContactEvent;
    }

    void OnDisable() {
        Physics.ContactEvent -= Physics_ContactEvent;
    }

    void Physics_ContactEvent(PhysicsScene scene, Unity.Collections.NativeArray<ContactPairHeader>.ReadOnly ContactPairHeader) {
        index = ContactPairHeader.Length-1;
        for (int j = 0; j < ContactPairHeader[index].PairCount; j++) {
            ref readonly ContactPair pair = ref ContactPairHeader[index].GetContactPair(j);

            if (pair.IsCollisionEnter) IsCollisionEnter(pair);     
            if (pair.IsCollisionStay) IsCollisionStay(pair);            
            if (pair.IsCollisionExit) IsCollisionExit(pair);
        }
    }

    static void IsCollisionEnter(ContactPair pair) {
        print("IsCollisionEnter: " + pair.GetContactPoint(0).Normal.ToString());
    }

    static void IsCollisionStay(ContactPair pair) {
        print("IsCollisionStay");
    }

    static void IsCollisionExit(ContactPair pair) {
        print("IsCollisionExit");
    }
}