using System;
using System.Diagnostics;
using UnityEngine;
using static Environment.Computer;

namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "BinarySortingTask", menuName = "Scriptable Objects/BinarySortingTask")]
    public class BinarySortingTask : Task {

        public NewJsonTask jsonTask;

        public override void Execute() {
            Stopwatch stopwatch = new();
            stopwatch.Start();
            BinarySearch(jsonTask.employees, DateTime.Parse("2234-08-07T20:08:00"));
            stopwatch.Stop();
            UnityEngine.Debug.Log("Time taken: " + stopwatch.ElapsedMilliseconds);
        }

        //public void BinarySort(EmployeeData[] Array) {
        //    for (int i = 1; i < Array.Length; i++) {
        //        EmployeeData x = Array[i];

        //        int j = Math.Abs(System.Array.BinarySearch(Array, 0, i, x) + 1);

        //        System.Array.Copy(Array, j, Array, j + 1, i - 1);

        //        Array[j] = x;
        //    }
        //}

        public int BinarySearch(EmployeeData[] inArray, DateTime x) {
            int low = 0; int high = inArray.Length - 1;

            for (int i = 0; i <= inArray.Length; i++) {
                int medianIndex = low + (high - low) / 2;

                if(DateTime.Parse(inArray[medianIndex].lastEntranceInEngineRoom) == x) {
                    UnityEngine.Debug.Log(inArray[medianIndex].name);
                    return medianIndex;
                }

                if(DateTime.Parse(inArray[medianIndex].lastEntranceInEngineRoom) < x) {
                    low = medianIndex + 1;
                }
                else {
                    high = medianIndex - 1;
                }
            }
            return -1;
        }
    }
}
