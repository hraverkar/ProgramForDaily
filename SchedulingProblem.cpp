
// C++ program for activity selection problem 
// when input activities may not be sorted. 
#include <bits/stdc++.h> 
using namespace std; 
  
// A job has a start time, finish time and profit. 
struct Activitiy 
{ 
    int start, finish; 
    char c ;
}; 
  
// A utility function that is used for sorting 
// activities according to finish time 
bool activityCompare(Activitiy s1, Activitiy s2) 
{ 
    return (s1.finish < s2.finish); 
} 
  
// Returns count of the maximum set of activities that can 
// be done by a single person, one at a time. 
void printMaxActivities(Activitiy arr[], int n) 
{ 
    // Sort jobs according to finish time 
    sort(arr, arr+n, activityCompare); 
  
    cout << "Following activities are selected  - "; 
  
    // The first activity always gets selected 
    int i = 0; 
    cout << "(" << arr[i].start << ", " << arr[i].finish << "), "; 
  
    // Consider rest of the activities 
    for (int j = 1; j < n; j++) 
    { 
      // If this activity has start time greater than or 
      // equal to the finish time of previously selected 
      // activity, then select it 
      if (arr[j].start >= arr[i].finish) 
      { 
          cout << "(" << arr[j].start << ", "
              << arr[j].finish << "), "; 
          i = j; 
      } 
    } 
} 
  
// Driver program 
int main() 
{ 
    Activitiy arr[] = {{1600, 1800}, {1200, 1300}, {1230, 1400}, {1400, 1630}}; 
    int n = sizeof(arr)/sizeof(arr[0]); 
    printMaxActivities(arr, n); 
    return 0; 
} 
