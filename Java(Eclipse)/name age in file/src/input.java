import java.io.*;

public class input {

	public static void main(String[] args) {
		File in=new File("my info.dat");
		try {
			PrintWriter e=new PrintWriter(in);
			e.println("My name is Ishmam");
			e.println("not in an appropriate age");
			e.close();
		
		}
		catch (IOException e) {
			
		} 
		
		

	}
}
