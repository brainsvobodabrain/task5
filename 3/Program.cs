/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int [] create_random_array(int count){
    int [] ret =new int[count];
    Random rand=new Random();
    if (count>0){
        for (int i=0; i<count; i++){
            ret[i]=rand.Next(0,100);
        }        
    }
    return ret;
}

string print_array(int[] array){
    return ("["+string.Join(", ",array)+"]");
}


int minus_max_min_elements(int[] arr){
    int max=arr[0];
    int min=arr[0];

    for (int i=0; i<arr.Length; i++){
        if (max<arr[i]){
            max=arr[i];
        }
        if (min>arr[i]){
            min=arr[i];
        }
    }
    return max-min;
}
int[] array=create_random_array(10);
System.Console.WriteLine($"{print_array(array)} -> {minus_max_min_elements(array)}");