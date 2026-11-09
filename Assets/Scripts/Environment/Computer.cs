using Environment.Tasks;
using System;
using UnityEngine;

namespace Environment {
    public class Computer : MonoBehaviour, IInteractable {

        [SerializeField] private GenericQueue<Task> tasks = new(); // Put your stack/queue here :)
        [SerializeField] private Task myTask;

        [System.Serializable]
        public class EmployeeData {
            public string name;
            public int employeeId;
            public bool hasEngineRoomClearance;
            public string lastEntranceInEngineRoom;
            public string lastExitFromEngineRoom;

            public static implicit operator int(EmployeeData v) {
                throw new NotImplementedException();
            }
        }

        public class Employees {
            public EmployeeData[] employees;
        }

        public void OnInteract() {
            //tasks.Dequeue().Execute();
            int length = tasks.Length();
            for (int i = 0; i < length; i++) {
                tasks.Dequeue().Execute();
            }
        }
    }
}
