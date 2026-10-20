using Environment.Tasks;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

namespace Environment {
    public class Computer : MonoBehaviour, IInteractable {

        [SerializeField] private GenericQueue<Task> tasks = new(); // Put your stack/queue here :)
        [SerializeField] private Task myTask;
        [SerializeField] private TextAsset employeeJSON;

        private void Awake() {
            EmployeeData data = JsonUtility.FromJson<EmployeeData>(employeeJSON.text);
            tasks.Enqueue(data.ConvertTo<Task>());
        }

        [System.Serializable]
        public class EmployeeData() {
            public string name;
            public int employeeId;
            public bool hasEngineInEngineRoom;
            public string lastEntranceInEngineRoom;
            public string lastExitFromEngineRoom;
        }

        public void OnInteract() {
            tasks.Dequeue().Execute();
        }
    }
}
