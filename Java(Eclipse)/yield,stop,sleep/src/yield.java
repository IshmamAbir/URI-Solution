
public class yield extends Thread{
	public void run() {
		for(int j=1;j<=3;j++) {
			System.out.println("From yeild :"+j);
			if (j==2)
				yield();
		}
	}

}
