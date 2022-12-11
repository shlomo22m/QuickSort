using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class QuickSort
{

	// function that swaps the numbers.
	static void swap(int[] arr, int i, int j)
	{
		int temp = arr[i];
		arr[i] = arr[j];
		arr[j] = temp;
	}

	/*   function takes last element as pivot, places
         the pivot element at its correct position in sorted
         array, and places all smaller than the pivot
         to left of pivot and all greater elements to right
         of pivot */
	static int partition(int[] arr, int low, int high)
	{

		// pivot 
		int pivot = arr[high];

		// Index of smaller element and
		// indicates the right position
		// of pivot found so far
		int i = (low - 1);

		for (int j = low; j <= high - 1; j++)
		{

			// If current element is smaller
			// than the pivot
			if (arr[j] < pivot)
			{

				// Increment index of
				// smaller element
				i++;
				swap(arr, i, j);
			}
		}
		swap(arr, i + 1, high);
		return (i + 1);
	}


	// arr is our array low is the start index , high is the end index
	static void quickSort(int[] arr, int low, int high)
	{
		if (low < high)
		{

			// set the location of the pivot first will be in the end and after in th middle
			int pi = partition(arr, low, high);

			// Separately sort elements smaller from the pivot.
			quickSort(arr, low, pi - 1);

			// Separately sort elements bigger from the pivot.
			quickSort(arr, pi + 1, high);
		}
	}

	public static void Main()
	{
		//set our array
		int[] arr = { 99, 1, 8, 9, 1, 5,89,34,73,100 };
		int n = arr.Length;

		//call to the quicksort function
		quickSort(arr, 0, n - 1);
		Console.Write("Sorted array: ");

		//print our sorted array
		foreach (int j in arr)
			Console.Write(j + " ");
	}
}