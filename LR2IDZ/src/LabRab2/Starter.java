package LabRab2;

import java.util.Scanner;

public class Starter {

	public static void main(String[] args) {
		Scanner sc = new Scanner (System.in);
		Робот мойРобот = Робот.Инициализация();
		System.out.println("Обот готов к работе!");
		System.out.println("Идентификация Оператора: ");
		System.out.println("ФИО > ");
		String фиоО = sc.nextLine();
		System.out.println("Номер пропуска > ");
		String пропускО = sc.next();
		Оператор работник = new Оператор (фиоО, пропускО);
		int операция = 0;
		do {
			System.out.print(
		", Выберите действие: \n1 - показать доступные кубы\n" +
		"2 - Поднять куб\n3 - Отпустить куб\n" +
		"0- выход\n Ваш выбор >");
			операция = sc.nextInt();
			switch(операция) {
			case 1: мойРобот.ДоступныеКубы(); break;
			case 2:
				//Какую куб брать?
				System.out.println("Код куба > ");
				String код = sc.next();
				мойРобот.ВыдачаКниги(код, работник);
				break;
			case 3:
				System.out.println("Код куба > ");
				String кодКуба = sc.next();
				мойРобот.ОтпуститьКуб(кодКуба, работник);
				break;
			default: break;
			}
		} while (операция != 0);
		sc.close();
		System.out.println("Робот-Манипулятор. Работа завершена!");
	}
}