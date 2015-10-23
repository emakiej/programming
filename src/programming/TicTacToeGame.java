package programming;

import java.awt.EventQueue;
import java.awt.GridLayout;
import java.awt.Image;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.IOException;
import java.util.ArrayList;

import javax.imageio.ImageIO;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JOptionPane;

/**
 * TicTacToeGame
 * @author gosia
 */
public class TicTacToeGame extends JFrame {

	private static final long serialVersionUID = 1L;
	private boolean user1 = true;
	private ArrayList<JButton> buttons = new ArrayList<JButton>();

	public TicTacToeGame() {
		initGame();
	}

	/**
	 * Executes game
	 */
	private void initGame() {
		setTitle("Tic Tac Toe Game");
		setSize(300, 300);
		setLocationRelativeTo(null);
		setDefaultCloseOperation(EXIT_ON_CLOSE);
		setLayout(new GridLayout(3, 3));
		for (int i = 0; i < 9; i++) {
			JButton button = new JButton();
			button.setToolTipText("");
			buttons.add(button);
			add(button);
		}
		for (JButton button: buttons) {
			button.addActionListener(new ActionListener() {
				public void actionPerformed(ActionEvent e) {
					// Execute when button is pressed
					if (button.getIcon() == null) {
						setImage(button);
						allFieldsfilled();
					}
				}
			});
		}
	}

	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			@Override
			public void run() {
				TicTacToeGame game = new TicTacToeGame();
				game.setVisible(true);
			}
		});
	}

	/**
	 * Sets image on clicked field
	 * @param button - clicked button
	 */
	private void setImage(JButton button) {
		Image img;
		if (user1) {
			try {
				img = ImageIO.read(getClass().getResource("/programming/resources/o.png"));
				button.setIcon(new ImageIcon(img));
				button.setToolTipText("O");
				if (isWinner()) end();
				user1 = false;
			} catch (IOException e1) {
				 // TODO Auto-generated catch block
				System.out.println("Image file not found!");
			}
		} else if (user1 == false){
			try {
				img = ImageIO.read(getClass().getResource("/programming/resources/x.png"));
				button.setIcon(new ImageIcon(img));
				button.setToolTipText("X");
				if (isWinner()) end();
				user1 = true;
			} catch (IOException e1) {
				// TODO Auto-generated catch block
				System.out.println("Image file not found!");
			}
		}
	}

	/**
	 * Checks if is winner of game
	 * @return true if the same images are vertically, horizontally or diagonally, otherwise false
	 */
	private boolean isWinner() {
		if(buttons.get(0).getToolTipText().equals(buttons.get(1).getToolTipText()) && buttons.get(1).getToolTipText().equals(buttons.get(2).getToolTipText()) && 
				!buttons.get(0).getToolTipText().equals("") && !buttons.get(1).getToolTipText().equals("") && !buttons.get(2).getToolTipText().equals("")) {
			return true;
		}
		if(buttons.get(3).getToolTipText().equals(buttons.get(4).getToolTipText()) && buttons.get(4).getToolTipText().equals(buttons.get(5).getToolTipText()) && 
				!buttons.get(3).getToolTipText().equals("") && !buttons.get(4).getToolTipText().equals("") && !buttons.get(5).getToolTipText().equals("")) {
			return true;
		}
		if(buttons.get(6).getToolTipText().equals(buttons.get(7).getToolTipText()) && buttons.get(7).getToolTipText().equals(buttons.get(8).getToolTipText()) && 
				!buttons.get(6).getToolTipText().equals("") && !buttons.get(7).getToolTipText().equals("") && !buttons.get(8).getToolTipText().equals("")) {
			return true;
		}
		if(buttons.get(0).getToolTipText().equals(buttons.get(3).getToolTipText()) && buttons.get(3).getToolTipText().equals(buttons.get(6).getToolTipText()) && 
				!buttons.get(0).getToolTipText().equals("") && !buttons.get(3).getToolTipText().equals("") && !buttons.get(6).getToolTipText().equals("")) {
			return true;
		}
		if(buttons.get(1).getToolTipText().equals(buttons.get(4).getToolTipText()) && buttons.get(4).getToolTipText().equals(buttons.get(7).getToolTipText()) && 
				!buttons.get(1).getToolTipText().equals("") && !buttons.get(4).getToolTipText().equals("") && !buttons.get(7).getToolTipText().equals("")) {
			return true;
		}
		if(buttons.get(2).getToolTipText().equals(buttons.get(5).getToolTipText()) && buttons.get(5).getToolTipText().equals(buttons.get(8).getToolTipText()) && 
				!buttons.get(2).getToolTipText().equals("") && !buttons.get(5).getToolTipText().equals("") && !buttons.get(8).getToolTipText().equals("")) {
			return true;
		}
		if(buttons.get(0).getToolTipText().equals(buttons.get(4).getToolTipText()) && buttons.get(4).getToolTipText().equals(buttons.get(8).getToolTipText()) && 
				!buttons.get(0).getToolTipText().equals("") && !buttons.get(4).getToolTipText().equals("") && !buttons.get(8).getToolTipText().equals("")) {
			return true;
		}
		if(buttons.get(2).getToolTipText().equals(buttons.get(4).getToolTipText()) && buttons.get(4).getToolTipText().equals(buttons.get(6).getToolTipText()) && 
				!buttons.get(2).getToolTipText().equals("") && !buttons.get(4).getToolTipText().equals("") && !buttons.get(6).getToolTipText().equals("")) {
			return true;
		}
		return false;
	}

	/**
	 * Checks if all fields are filled, if yes there is no winner
	 */
	private void allFieldsfilled() {
		if(!buttons.get(0).getToolTipText().equals("") && !buttons.get(1).getToolTipText().equals("") && !buttons.get(2).getToolTipText().equals("") &&
				!buttons.get(3).getToolTipText().equals("") && !buttons.get(4).getToolTipText().equals("") && !buttons.get(5).getToolTipText().equals("") &&
				!buttons.get(6).getToolTipText().equals("") && !buttons.get(7).getToolTipText().equals("") && !buttons.get(8).getToolTipText().equals("")) {
			JOptionPane.showMessageDialog(null, "There is no winner");
			System.exit(0);
		}
	}

	/**
	 * Displays winner and ends game
	 */
	private void end() {
		if (user1) {
			JOptionPane.showMessageDialog(null, "User with '0' is winner");
		} else {
			JOptionPane.showMessageDialog(null, "User with 'X' is winner");
		}
		System.exit(0);
	}
}