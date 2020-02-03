package writer_from_file;



import java.io.*;
import java.util.Scanner;

public class output_display {

	public static void main(String[] args) {
		File in=new File("my info.dat");
		try {
			Scanner sc=new Scanner(in);
			String name=sc.nextLine();
			String age=sc.nextLine();
			System.out.printf("name=%s\nAge=%s",name,age);
			sc.close();
		}
		catch(FileNotFoundException ex) {
			System.out.println(ex);
		} 

	}

}
