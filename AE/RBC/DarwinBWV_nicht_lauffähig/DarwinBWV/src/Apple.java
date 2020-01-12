/** Apples are food for other creatures; they just sit still and don't
    attack.*/
public class Apple extends Creature {
    @Override
	public String getAuthorName() {
        return "Darwin SDK";
    }

    @Override
	public String getDescription() {
        return "Apples are food for other creatures; they just sit still and don't attack.";
    }

    @Override
	public void run() {}
}
