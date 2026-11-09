using Environment.Tasks;
using System;
using UnityEngine;
using static Environment.Computer;

[CreateAssetMenu(fileName = "SortingTasks", menuName = "Scriptable Objects/SortingTasks")]
public class SortingTasks : Task {

    public NewJsonTask jsonTask;

    public override void Execute() {
        QuickSort(jsonTask.employees, 0, jsonTask.employees.Length - 1);

        foreach(EmployeeData employee in jsonTask.employees) {
            Debug.Log("Last time entered engine room : " + employee.lastEntranceInEngineRoom);
        }
    }

    public void QuickSort(EmployeeData[] Array, int left, int right) {
        if (left < right) {
            int pivotIndex = Partition(Array, left, right);
            QuickSort(Array, left, pivotIndex - 1);
            QuickSort(Array, pivotIndex + 1, right);
        }
    }

    public int Partition(EmployeeData[] Array, int left, int right) {
        DateTime pivot = DateTime.Parse(Array[right].lastEntranceInEngineRoom);
        int i = left - 1;

        for (int j = left; j < right; j++) {
            DateTime date = DateTime.Parse(Array[j].lastEntranceInEngineRoom);
            if (date < pivot) {
                i += 1;
                (Array[j], Array[i]) = (Array[i], Array[j]);
            }
        }

        (Array[i + 1], Array[right]) = (Array[right], Array[i + 1]);
        return i + 1;
    }
}
