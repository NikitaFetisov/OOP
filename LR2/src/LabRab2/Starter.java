package LabRab2;

import java.util.Scanner;

public class Starter {

	public static void main(String[] args) {
		Scanner sc = new Scanner (System.in);
		Библиотека мояБиблиотека = Библиотека.Инициализация();
		System.out.println("Библиотека готова к работе!");
		System.out.println("Идентификация читателя: ");
		System.out.println("ФИО > ");
		String фиоЧ = sc.nextLine();
		System.out.println("Читательский билет > ");
		String билетЧ = sc.next();
		Читатель клиент = new Читатель (фиоЧ, билетЧ);
		int операция = 0;
		do {
			System.out.print("Уважаемый " + клиент.фио +
		", Выберите действие: \n1 - вывод каталога\n" +
		"2 - Запрос книги\n3 - Сдача книги\n" +
		"0- выход\n Ваш выбор >");
			операция = sc.nextInt();
			switch(операция) {
			case 1: мояБиблиотека.Каталог(); break;
			case 2:
				//Какую книгу брать?
				System.out.println("Код книги > ");
				String код = sc.next();
				мояБиблиотека.ВыдачаКниги(код, клиент);
				break;
			case 3:
				мояБиблиотека.ВозвратКниги(клиент);
				break;
			default: break;
			}
		} while (операция != 0);
		sc.close();
		System.out.println("Библиотека. Работа завершена!");
	}
}