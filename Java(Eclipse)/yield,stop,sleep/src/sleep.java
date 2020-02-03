
public class sleep extends Thread{
	public void run() {
		for(int i=1;i<=5;i++) {
			System.out.println("From sleep :"+i);
			if (i==2) {
				try {
				sleep(1500);
				}
			catch(Exception e) {
				
				
			}
			}
	}

}
}
