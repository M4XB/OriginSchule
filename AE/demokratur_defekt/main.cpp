#include <QCoreApplication>

#include <iostream>
#include <signal.h>

// signal handling
static bool interrupted = false;
void SignalHandler(int signal) {
    std::cout << std::endl << "[demokratur] Received signal: " << signal << std::endl << std::endl;
    interrupted = true;
}

class showpeople {

    int number_of_people_;
    int number_of_rows_;

public:

    showpeople(int number_of_people = 0, int number_of_rows = 0) : number_of_people_(number_of_people), number_of_rows_(number_of_rows) {
        PrintConfig();
    }

    void PrintConfig() {
        std::cout  << std::endl << "[demokratur] [class showpeople]  config: " << std::endl;
        std::cout << "[demokratur] [class showpeople]            number_of_people_ = " << number_of_people_ << std::endl;
        std::cout << "[demokratur] [class showpeople]            number_of_rows_   = " << number_of_rows_  << std::endl << std::endl;
    }

    // define marker of sing ale person's party
    std::string showperson(int party) {
        std::string printout = " ";
        if (party==0) {
            printout = "X";
        } else {
            printout = "-";
        }
        return printout;
    }

    // output of people array to console
    void showarray(int * people) {
        for (int i=0; i<number_of_people_; i++) {
            std::cout << showperson(people[i]);
            if (!((i+1)%20)) {
                std::cout << std::endl;
            }
        }
    }
};

class interaction {

    int number_of_people_;
    int number_of_rows_;

public:
    interaction(int number_of_people = 0, int number_of_rows = 0) : number_of_people_(number_of_people), number_of_rows_(number_of_rows) {}

    void PrintConfig() {
        std::cout  << std::endl << "[demokratur] [class interaction]  config: " << std::endl;
        std::cout << "[demokratur] [class interaction]            number_of_people_ = " << number_of_people_ << std::endl;
        std::cout << "[demokratur] [class interaction]            number_of_rows_   = " << number_of_rows_  << std::endl << std::endl;
    }

    // select person who is willing to convince another
    int pickconvincer() {
        int convincer = -1;
        convincer = rand()%number_of_people_;  // results in a number between 0 and number_of_people-1, which matches the position in the c++ array of size number_of_people
        return convincer;
    }

    // select one out of 4 options (left, roght, up, down) of possible other persons to convoince
    int picktalker(int convincer) {
        int talker = rand()%4;  // selects one out of four possible neighbours to talk to, i.e. # 0..3

        if (talker == 0) {  // left neighbour
            if ((convincer%number_of_rows_ == 0) && (convincer%(number_of_rows_+1) == 0)) { talker = convincer+(number_of_rows_-1); }
            else { talker = convincer-1; }
        } else if (talker == 1) {  // right neighbour
            if (((convincer+1)%number_of_rows_ == 0) && ((convincer+1)%(number_of_rows_+1) == 0)) { talker = convincer-(number_of_rows_+1); }
            else { talker = convincer+1; }
        } else if (talker == 2) {  // up neighbour
            if (convincer < number_of_rows_) { talker = convincer+number_of_people_-number_of_rows_; }
            else { talker = convincer-number_of_rows_; }
        } else if (talker == 3) {  //  down neighbour
            if (convincer >= (number_of_people_-number_of_rows_)) { talker = convincer-number_of_people_+number_of_rows_; }
            else { talker = convincer+number_of_rows_; }
        } else {  // this should never happen
            std::cerr << "[demokratur] ERROR in pickconcersation(..): Found incompatible convincer/talker position!!" << std::endl;
            talker = -1;
        }
        return talker;
    }
};

// main action happens here: find convincer, select talker, eventually change talkers party
class talkandconvince : public interaction, public showpeople {

    int *people;

public:
    talkandconvince(int number_of_people = 0, int number_of_rows = 0) : interaction(number_of_people,number_of_rows), showpeople(number_of_people,number_of_rows) {
        number_of_people_ = number_of_people;
        number_of_rows_ = number_of_rows;
        people = new int[number_of_people_];
        interaction::PrintConfig();
        showpeople::PrintConfig();
    }
    ~talkandconvince() {
        delete [] people;
    }

    int * GetPeople() { return people; }

    void gameloop() {
        int convincer = pickconvincer();
        int talker = picktalker(convincer);

        bool talkerwasconvinced = rand()%2;  // 50% chance to be convinced
        if (talkerwasconvinced != 0) {
            people[talker] = people[convincer];
        }
    }

    // check if game ended in a dictatorship, i.e. all people have the same party
    bool checkpeople() {
        bool dictatorship = true;
        int party = people[0];
        for (int i=1; i<number_of_people_; i++) {
            if (people[i] != party) {
                dictatorship = false;
                break;
            }
        }
        return dictatorship;
    }
};

int main(int argc, char **argv) {

    std::cout << "[demokratur] Starting ... " << std::endl << std::endl;

    QCoreApplication a(argc, argv);

    int neventstogenerate = -1;
    int nsteps = 1000;
    int verbosity = 1;

    bool TestingMode = false;

    for (int i=0; i<argc; ++i) {

        if (strcmp(argv[i], "--help") == 0 || strcmp(argv[i], "-h") == 0) {
            std::cout << std::endl;
            std::cout << "[demokratur] Usage of demokratur:" << std::endl;
            std::cout << "[demokratur]   -h" << std::endl;
            std::cout << "[demokratur]   -help" << std::endl;
            std::cout << "[demokratur]       Prints out the usage information for this program." << std::endl << std::endl;

            std::cout << "[demokratur]   -s <steps before next output>" << std::endl;
            std::cout << "[demokratur]   --steps <steps before next output>" << std::endl;
            std::cout << "[demokratur]       Number of steps before next output." << std::endl << std::endl;

            std::cout << "[demokratur]   -v <level>" << std::endl;
            std::cout << "[demokratur]   --verbosity <level>" << std::endl;
            std::cout << "[demokratur]       Verbosity level of printouts." << std::endl << std::endl;

            std::cout << "[demokratur]   --test" << std::endl;
            std::cout << "[demokratur]       Run some test." << std::endl << std::endl;

            exit(1);
        }

        if ((strcmp(argv[i], "--steps") == 0 || strcmp(argv[i], "-s") == 0) && (i+1 < argc)) {
            nsteps = atoi(argv[i+1]);
        }
        if ((strcmp(argv[i], "--verbosity") == 0 || strcmp(argv[i], "-v") == 0) && (i+1 < argc)) {
            verbosity = atoi(argv[i+1]);
        }
        if (strcmp(argv[i], "--test") == 0) {
            TestingMode = true;
        }
    }

    if (TestingMode) {
        std::cout << std::endl << "[demokratur] Testing mode is ON!" << std::endl << std::endl;
        neventstogenerate = 10;
        verbosity = 2;
    }

    // enable signals to eventually stop gracefully
    signal(SIGINT, SignalHandler);

    std::cout << "[demokratur] Verbosity level = " << verbosity  << std::endl;
    std::cout << "[demokratur] Step size for output = " << nsteps  << std::endl;

    std::cout << std::endl << "[demokratur] Initalizing  ... " << std::endl;

    int seed;
    if (TestingMode) {
        seed = 1;
        std::cout  << "[demokratur] Setting same seed for testing i.e. reproducability: " << seed << std::endl;

    }
    else {
        seed = time(NULL);
        std::cout << "[demokratur] Setting random seed: " << seed << std::endl;
    }
    srand(seed);

    int number_of_people = 400;
    int number_of_rows = 20;

    talkandconvince world(number_of_people,number_of_rows);

    int *people = world.GetPeople();
    for (int i=0; i<number_of_people; i++) {
        people[i] = rand()%2;
    }

    if (TestingMode) {
        std::cout << std::endl << "[demokratur] Dumping poeple array ..." << std::endl;
        for (int i=0; i<number_of_people; i++) {
            std::cout << "[demokratur] Person #: " << i << "is set to: " << people[i] << std::endl;
        }
        std::cout << "[demokratur] ... dumping poeple array done." << std::endl << std::endl;
    }

    std::cout << "[demokratur]  ... initializing done."  << std::endl << std::endl;


    try {

        std::cout << "[demokratur] Starting game loop  ... " << std::endl;
        system("cls");
        if (verbosity>1) {
            std::cout << "[demokratur] inside game loop  ... "  << std::endl;
        }
        world.showarray(world.GetPeople());

        int step = 0;
        while(true && !interrupted) {
            if (!(step%nsteps))  {
                system("cls");
                if (verbosity>1) {
                    std::cout << "[demokratur] inside game loop  ... " << std::endl;
                    std::cout << "[demokratur] step = " << step << std::endl;
                }
                world.showarray(people);
                if (world.checkpeople()) {
                    std::cout << std::endl << "[demokratur] We have dictatorship after less than: " << step << " iterations. " << std::endl << std::endl;
                    break;
                }
            };
            step++;
            world.gameloop();
        }

        std::cout << "[demokratur] ... game loop ended." << std::endl;

    }
    catch(std::runtime_error &e) {
        std::cerr << "[demokratur] ERROR: " << e.what() << std::endl;
        return 1;
    }

    std::cout << std::endl << "[demokratur] ... done." << std::endl;

    return a.exec();
}

