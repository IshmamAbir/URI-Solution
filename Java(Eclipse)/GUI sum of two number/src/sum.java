import javax.swing.JOptionPane;
public class sum {

	public static void main(String[] args) {
		JOptionPane j=new JOptionPane();
		String a=j.showInputDialog(null, "Type 1st number", "1st number",3);
		String b=j.showInputDialog(null, "Input 2nd number","2nd number", 3);
		int c=Integer.parseInt(a);
		int d=Integer.parseInt(b);
		
		int sum=c+d;
		
		j.showMessageDialog(null, "The sum is :" +sum , "Sum", 1);
		

	}

}
