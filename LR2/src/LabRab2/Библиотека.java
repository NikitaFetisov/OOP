package LabRab2;

import java.util.Hashtable;
import java.util.Map.Entry;
import java.util.Optional;
import java.util.Vector;

public class Библиотека {
	
	Hashtable <Книга, Vector<Читатель>> книги =
			new Hashtable<Книга, Vector<Читатель>>();
	
	private Библиотека ( ) {}
	
	public static Библиотека Инициализация() {
		Библиотека res = new Библиотека();
		Книга новый = new Книга();
		новый.автор = "Коротков А.Е.";
		новый.жанр = Жанр.Образование;
		новый.код = "001";
		
		новый.название = "Программирование Java";
		новый.состояние = Состояние.Доступна;
		res.книги.put(
				новый, 
				new Vector<>());
		
		новый = new Книга();
		новый.автор = "Тодеев А.А.";
		новый.жанр = Жанр.Образование;
		новый.код = "002";
		новый.название = "Java. Учебник";
		новый.состояние = Состояние.Доступна;
		res.книги.put(
				новый, 
				new Vector <>());
		
		return res;
	}	
	public void ВыдачаКниги (String кодКниги, Читатель читатель) {
		//Ищем книгу с переданными кодом
		Optional<Entry<Книга, Vector<Читатель>>> find = 
				книги.entrySet().stream().filter(e->e.getKey().код.equals(кодКниги)).findFirst();
		
		// если книга нашлась
		if(find.isPresent()) {
			//Проверяем доступность
			if(find.get().getKey().состояние == Состояние.Доступна) {
				find.get().getKey().состояние = Состояние.НаРуках;
				find.get().getValue().add(читатель);
				System.out.println("Выдача книги зафиксирована");		
			}
			else
				System.out.println("Книга на руках!!!");
		}
		else
			System.out.println("Книги с таким кодом нет");		
	}
	public void ВозвратКниги(Читатель читатель) {
		System.out.println("function is not realized");
	}
	
	public void Каталог() {
		книги.entrySet().stream().forEach(e->{
			Книга tek = e.getKey();
			System.out.println(tek.автор + "\n" + tek.название + "\n" + tek.код + "\n");
		});
	}
}
