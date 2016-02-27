package programming;

/**
 * Prints prime numbers from 2 to X
 * @author gosia
 *
 */
public class PrintNumbers {
	private static int X = 0;

	public static void main(String[] args) {
		if (checkInputData(args)) {
			for (int number = 2; number < X; number++) {
				if (!isNotPrime(number)) System.out.println(number);
			}
		}
	}

	/**
	 * Checks if input data are correct and greater than 2
	 * @param numbers - input data
	 * @return True if input data are correct or greater than 2, otherwise false
	 */
	private static boolean checkInputData(String[] numbers) {
		if (numbers.length > 0) {
			try {
				X = Integer.parseInt(numbers[0]);
				if (X >= 2) {
					return true;
				} else {
					System.out.println("The number should be greater than 2");
					return false;
				}
			} catch (NumberFormatException e) {
				System.out.println("The number is not correctly");
			}
			return true;
		} else {
			System.out.println("X is not specified");
			return false;
		}
	}

	/**
	 * Checks if number is not prime
	 * @param number to check if is not prime
	 * @return true if is not prime, otherwise false
	 */
	private static boolean isNotPrime(int number) {
		for (int j = 2; j < number; j++) {
			if (number % j == 0) {
				return true;
			}
		}
		return false;
	}
}