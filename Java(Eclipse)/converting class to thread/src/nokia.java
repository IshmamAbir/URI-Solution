
public class nokia {

	public static void main(String[] args) {
		mmyclass runnable=new mmyclass();
		Thread a=new Thread(runnable);
		
		wifi bluetooth=new wifi();
		Thread b=new Thread(bluetooth);
		
		a.start();
		b.start();

	}

}
