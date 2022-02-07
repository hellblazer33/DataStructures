String[] arr = { "contribute", "geeks", "ide", "practice" };
String x = "ide";

int result = BinarySearchClass.binarySearch(arr, x);

if (result == 0)
    Console.WriteLine("Element not present");
else
    Console.WriteLine("Element found at "
                    + "index " + result);