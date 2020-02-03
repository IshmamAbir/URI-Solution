import  javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
public class xm {

	public static void main(String[] args) {
		JFrame j=new JFrame();
		j.setVisible(true);
		j.setTitle("Calculator");
		j.setSize(400, 300);
		j.setLocation(500, 250);
		j.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
		Container c=new Container();
		c=j.getContentPane();
		c.setBackground(Color.gray);;
		c.setLayout(null);
		
		
		JButton j1=new JButton("Add");
		JButton j2=new  JButton("Sub");
		j1.setBounds(100, 170, 100, 60);
		j2.setBounds(200,170,100,60);
		c.add(j1);
		c.add(j2);
		

		
		j1.addActionListener(new ActionListener(){

			public void actionPerformed(ActionEvent e) {
				String   a=JOptionPane.showInputDialog(null, "1st number","first value",3);
				String   b=JOptionPane.showInputDialog(null, "2nd number","Second Value value",3);
				int c=Integer.parseInt(a);
				int d=Integer.parseInt(b);
				int sum =  c+d;
				JOptionPane.showMessageDialog(null, "Sum is: "+sum,"Result",1);
			}

			
		});
		
		
		j2.addActionListener(new ActionListener() {
			
			public void actionPerformed(ActionEvent e) {
				String   a=JOptionPane.showInputDialog(null, "1st number","first value",3);
				String   b=JOptionPane.showInputDialog(null, "2nd number","Second Value value",3);
				int c=Integer.parseInt(a);
				int d=Integer.parseInt(b);
				int sub =  c-d;
				JOptionPane.showMessageDialog(null, "Subtraction is: "+sub,"Result",1);
				
				
				
			}
		});
		

	}

}
