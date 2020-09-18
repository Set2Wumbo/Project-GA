using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ProjectGA
{
    class GAClass
    {
        //Variables for parameter set up
        //external connection
        public int populationSize;
        public int numOfPeriods;
        public double orderProbability;
        public double mutationProbability;
        public double crossoverProbability;
        public decimal costPerUnitPerPeriod;
        public decimal setUpCostPerOrder;

        //internal variable connection
        public static int popSize;
        public static int Periods;
        public static double orderProb;
        public static double mutProb;
        public static double crossProb;
        public static decimal costUnit;
        public static decimal costOrder;
        

        //Create new jagged array
        //Method to generate binary chromosomes
        //static var for later use
        public int[][] chromosomes;
        public static int[][] chromos;
        static Random rand;
        static int tempNum;
        public void Generate_Chromosomes()
        {
            //intialize array
            chromosomes = new int[populationSize][];
            chromos = new int[populationSize][];
            // Instantiate random number generator using system-supplied value as seed.
            rand = new Random();

            //loop for however many chromos
            for (int i = 0; i < populationSize; i++)
            {

                //set the amount perioids for the chromo
                chromosomes[i] = new int[numOfPeriods];
                chromos[i] = new int[numOfPeriods];

                //loop for however many periods
                for(int j = 0; j < numOfPeriods; j++)
                {
                    tempNum = rand.Next(101);
                    
                    //Assigns if random is less then prob or the start of an order
                    if (tempNum < (orderProbability * 100) || j == 0)
                    {
                        //assign 1 at specific period
                        chromosomes[i][j] = 1;
                        chromos[i][j] = 1;
                    }
                    else
                    {
                        //assign 0 at specific period
                        chromosomes[i][j] = 0;
                        chromos[i][j] = 0;
                    }
                }                
            }
            store_Variables();            
        }

        //method to get Fitness function value
        int[] fitnessFunction;
        public static int[] fF;
        public void find_Fitness_Function()
        {

            //Check for errors
            if (chromos != null)
            {
                //intialize FF Array
                //prepare the for loops for the chromosome array and net requiremnents
                fitnessFunction = new int[popSize];
                for (int i = 0; i < popSize; i++)
                {
                    for (int j = 0; j < Periods; j++)
                    {

                        //Multiple the chromo binary 1 or 0 to the net requirement
                        //Determines if order was made or not
                        //Yes, order
                        if (chromos[i][j] * netReq[j] != 0)
                        {
                            //Add an order charge
                            fitnessFunction[i] = int.Parse(costOrder.ToString()) + fitnessFunction[i];
                        }
                        //No, order
                        else
                        {
                            int tempCount = j;
                            int sumOfCarry = 0;

                            //Damn im good...
                            if (tempCount == chromos[i].Length)
                            {
                                sumOfCarry = sumOfCarry + netReq[tempCount];
                            }
                            else
                            {
                                while (chromos[i][tempCount] == 0)
                                {
                                    sumOfCarry = sumOfCarry + netReq[tempCount];
                                    tempCount = tempCount + 1;

                                    if (tempCount == chromos[i].Length)
                                    {
                                        break;
                                    }
                                }
                            }

                            fitnessFunction[i] = sumOfCarry * int.Parse(costUnit.ToString()) + fitnessFunction[i];
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Error occurred while calculating FF.");
            }
            //Save locally for the GA Class
            fF = fitnessFunction;
        }

        //method to collect generation pools of chromosomes
        static int[][][] GenePool = new int[genCount][][];
        static int[][] GenePoolfF = new int[genCount][];
        static int geneCount = 0;        
        public void collect_gen_gene_pool(int[][] currentChromosomes)
        {
            if (genCount >= 0)
            {
                GenePool[geneCount] = currentChromosomes;
                geneCount = 1 + geneCount;                
            }           
        }

        //method to collect the number of generations to perform
        static int genCount = 0;
        public void update_generation_pool(int generations)
        {
            //maksure it isn't empty
            if (generations.ToString() != null)
            {
                //collect the number of generations
                //collect to the first generation array
                genCount = generations;
                collect_gen_gene_pool(chromos);
            }
            else
            {
                genCount = 0;
            }
        }

        //saves the variables for later use
        private void store_Variables() 
        {
            popSize = populationSize;
            Periods = numOfPeriods;
            orderProb = orderProbability;
            mutProb = mutationProbability;
            crossProb = crossoverProbability;
            costUnit = costPerUnitPerPeriod;
            costOrder = setUpCostPerOrder;            
        }

        //method to find the best chromo out of the current population
        static int minfF = 10000000;
        static int[] theBestChromo;
        static int bestGeneNum;
        static int chromoNum;
        public int get_Best_Chromo()
        {
            if (genCount == 0)
            {
                for (int i = 0; i < fF.Length; i++)
                {
                    if (fF[i] < minfF)
                    {
                        minfF = fF[i];

                        bestGeneNum = 0;
                        chromoNum = i;
                        theBestChromo = chromos[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < fF.Length; i++)
                {
                    if (fF[i] < minfF)
                    {
                        minfF = fF[i];

                        double generationNum = i / popSize;
                        bestGeneNum = int.Parse(Math.Floor(generationNum).ToString());
                        int chromosome =  (i / popSize - bestGeneNum) * popSize ;
                        chromoNum = chromosome;
                        theBestChromo = GenePool[bestGeneNum][chromosome];
                    }
                }
            }
            return minfF;
        }

        //method to find the best chromo out of the current population
        static int maxfF = 0;
        static int[] theWorstChromo;
        static int worseGeneNum;
        static int worseChromoNum;
        public int get_Worst_Chromo()
        {
            if (genCount == 0)
            {
                for (int i = 0; i < fF.Length; i++)
                {
                    if (fF[i] > maxfF)
                    {
                        maxfF = fF[i];

                        worseGeneNum = 0;
                        worseChromoNum = i;
                        theWorstChromo = chromos[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < fF.Length; i++)
                {
                    if (fF[i] > maxfF)
                    {
                        maxfF = fF[i];

                        double generationNum = i / popSize;
                        worseGeneNum = int.Parse(Math.Floor(generationNum).ToString());
                        int chromosome = (i / popSize - worseGeneNum) * popSize;
                        chromoNum = chromosome;
                        theWorstChromo = GenePool[worseGeneNum][chromosome];
                    }
                }
            }
            return maxfF;
        }

        //mthod to get the best chromo
        public int[] get_the_best_chromo_with_periods()
        {
            if(theBestChromo.ToString() != null)
            {
                return theBestChromo;
            }
            else
            {
                return null;
            }
        }

        //mthod to get the best chromo
        public int[] get_the_worst_chromo_with_periods()
        {
            if (theBestChromo.ToString() != null)
            {
                return theWorstChromo;
            }
            else
            {
                return null;
            }
        }

        public int get_generation_count()
        {
            return genCount;
        }

        //method to get pop size
        public int get_Pop_Size()
        {
            return popSize;
        }

        //method to get the number of periods
        public int get_num_Periods()
        {
            return Periods;
        }

        //method to retieve Fitness fucntion scores
        public int[] get_fitness_function_scores()
        {
            if(fF != null)
            {
                return fF;
            }
            else
            {
                return null;
            }
        }

        //method to get chromos 1 or 0 for that period 
        public int get_chromosome(int chromoNum, int periodOfChromo)
        {
            return chromos[chromoNum][periodOfChromo];
        }

        //method to get all chromosomes
        public int[][] get_chromosomes()
        {
            if(chromos != null)
            {
                return chromos;
            }
            else
            {
                return null;
            }
        }
        
        //Method to retieve net requirements
        public int[] get_net_requirements()
        {
            if(netReq != null)
            {
                return netReq;
            }
            else
            {
                return null;
            }
        }

        //Method to collect the new chromosome population
        public void update_Chromosome_Pop(int[][]NewChromos)
        {
            if(NewChromos != null)
            {
                chromos = NewChromos;
            }
            else
            {
                MessageBox.Show("Error while collecting new chromosomes");
            }
        }

        //method to get Net Requirements
        //Output netReq
        public static int[] netReq;
        public void update_net_requirements(int[] netRequirements)
        {
            if (netRequirements != null)
            {
                //store the variable locally
                netReq = netRequirements;
            }
            else
            {
                MessageBox.Show("An error occured while trying to collect the Net Requirements.");
            }
        }

        
    }
}
