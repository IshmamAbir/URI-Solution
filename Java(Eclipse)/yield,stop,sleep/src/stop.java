
public class stop extends Thread{
	public void run() {
		for (int k=1;k<=10;k++) {
			System.out.println("From stop : "+k);
			if (k==4)
				stop();
		}
	}

}
