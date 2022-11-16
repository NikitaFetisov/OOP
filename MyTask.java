package LR1;

import java.util.ArrayList;
import java.util.Scanner;

public class MyTask {

	public static void main(String[] args) 
	{
		Scanner sc = new Scanner(System.in);
		System.out.print("Введите количество чисел >>> ");
		int N = sc.nextInt();
		
		double a;
		ArrayList<Double> aa = new ArrayList();
		
		for (int i = 0; i < N; i++) {
				System.out.print("Введите число " + String.valueOf(i+1) + " >>>");
				a = sc.nextDouble();
				aa.add(a);
		}
		
		double b = 0;
		System.out.println("Результирующая последовательность = ");
		for (int i = 0; i< N; i++) {
			b = (aa.get(i)*aa.get(i)*aa.get(i));
			System.out.println(b);
		}
		sc.close();
	}

}
