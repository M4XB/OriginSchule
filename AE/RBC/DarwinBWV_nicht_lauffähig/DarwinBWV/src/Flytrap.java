/** Dangerous creature rooted in place. Continuously spins to the left
 * and blindly attacks. */
public class Flytrap extends Creature {
    @Override
	public void run() {
        while (true) {
            attack();
            turnLeft();
        }
    }

    @Override
	public String getAuthorName() {
        return "Darwin SDK";
    }

    @Override
	public String getDescription() {
        return "Dangerous creature rooted in place. Continuously " +
            "spins to the left and blindly attacks.";
    }
}
