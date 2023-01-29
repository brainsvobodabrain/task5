/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

int summ_oddpos_elements(int[] arr){
    int summ=0;
    for (int i=0; i<arr.Length; i++){
        if (i%2!=0){
            summ=summ+arr[i];
        }
    }
    return summ;
}
int[] array=create_random_array(4);
System.Console.WriteLine($"{print_array(array)} -> {summ_oddpos_elements(array)}");