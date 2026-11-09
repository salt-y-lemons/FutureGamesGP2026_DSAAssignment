using System;
using UnityEngine;
using static Environment.Computer;

namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "NewJsonTask", menuName = "Scriptable Objects/NewJsonTask")]

    public class NewJsonTask : Task {
        [SerializeField] private TextAsset employeeJSON;
        public EmployeeData[] employees;

        public override void Execute() {
            employees = JsonUtility.FromJson<Employees>(employeeJSON.text)?.employees;
        }
    }
}
    
