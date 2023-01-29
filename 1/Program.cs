/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int [] create_random_array(int count){
    int [] ret =new int[count];
    Random rand=new Random();
    if (count>0){
        for (int i=0; i<count; i++){
            ret[i]=rand.Next(100,1000);
        }        
    }
    return ret;
}
int count_honest(int[] array){
    int ret=0;
    for (int i=0; i<array.Length;i++){
        if (array[i]%2==0){
            ret++;
        }
    }
    return ret;
}
string print_array(int[] array){
    return ("["+string.Join(", ",array)+"]");
}

int[] array=create_random_array(10);
System.Console.WriteLine($"Колличество четных чисел в массиве {print_array(array)} составляет {count_honest(array)}");