import java.io.*;

public class copy {

	public static void main(String[] args) {
		File in=new File("personalinfo.txt");
		File out=new File("copyinfo.txt");
		
		//FileReader is=null;
		//FileWriter os=null;
		
	/*	try {
			PrintWriter p=new PrintWriter(in);
			p.println("my name");
			p.println("my address");
			p.close();

	}
		catch(IOException e){
			
		}*/
		
		try {
			FileReader is=new FileReader(in);
			FileWriter os=new FileWriter(out);
			
			int a;
			while ((a=is.read())!=-1) {
				os.write(a);
			}
			
		}
		catch (IOException e) {
			
		}

	}

}
