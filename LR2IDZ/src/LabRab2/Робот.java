package LabRab2;

import java.util.Hashtable;
import java.util.Map.Entry;
import java.util.Optional;
import java.util.Vector;

public class Робот {
	
	Hashtable <Куб, Vector<Оператор>> кубы =
			new Hashtable<Куб, Vector<Оператор>>();
	
	private Робот( ) {}
	
	public static Робот Инициализация() {
		Робот res = new Робот();
		Куб новый = new Куб();
		новый.код = "001";
		новый.цвет = Цвет.Зеленый;
		новый.состояние = Состояние.НеПримагничен;
		res.кубы.put(
				новый, 
				new Vector<>());
		
		новый = new Куб();
		новый.код = "002";
		новый.цвет = Цвет.Красный;
		новый.состояние = Состояние.НеПримагничен;
		res.кубы.put(
				новый, 
				new Vector <>());
		
		новый = new Куб();
		новый.код = "003";
		новый.цвет = Цвет.Черный;
		новый.состояние = Состояние.НеПримагничен;
		res.кубы.put(
				новый, 
				new Vector <>());
		
		return res;
	}	
	public void ВыдачаКниги (String кодКуба, Оператор оператор) {
		//Ищем куб с переданными кодом
		Optional<Entry<Куб, Vector<Оператор>>> find = 
				кубы.entrySet().stream().filter(e->e.getKey().код.equals(кодКуба)).findFirst();
		
		// если куб найден
		if(find.isPresent()) {
			//Проверяем доступность
			if(find.get().getKey().состояние == Состояние.НеПримагничен) {
				find.get().getKey().состояние = Состояние.Примагничен;
				find.get().getValue().add(оператор);
				System.out.println("Куб примагничен\n");		
			}
			else
				System.out.println("Куб уже примагничен\n");
		}
		else
			System.out.println("Куба с таким кодом нет\n");		
	}
	public void ОтпуститьКуб(String кодКуба, Оператор оператор) {
		Optional<Entry<Куб, Vector<Оператор>>> find = 
				кубы.entrySet().stream().filter(e->e.getKey().код.equals(кодКуба)).findFirst();
		
		// если куб найден
		if(find.isPresent()) {
			//Проверяем доступность
			if(find.get().getKey().состояние == Состояние.Примагничен) {
				find.get().getKey().состояние = Состояние.НеПримагничен;
				find.get().getValue().add(оператор);
				System.out.println("Куб Отмагничен\n");		
			}
			else
				System.out.println("Куб ещё не примагничен\n");
		}
		else
			System.out.println("Куба с таким кодом нет\n");
	}
	
	public void ДоступныеКубы() {
		кубы.entrySet().stream().forEach(e->{
			Куб tek = e.getKey();
			System.out.println(tek.цвет + "\n" + tek.код + "\n" + tek.состояние + "\n");
		});
	}
}
