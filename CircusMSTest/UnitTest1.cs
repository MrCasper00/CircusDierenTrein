using CircusLib;
namespace CircusMSTest
{
    [TestClass]
    public class UnitTestAnimalDistruibution
    {
        [TestMethod]
        public void Scenario1()
        {
            //Arrange
            Circus Circus = new Circus();
            AddAnimalsToTrain("Carnivore large", true, Sizes.B, 0);
            AddAnimalsToTrain("Carnivore medium", true, Sizes.M, 0);
            AddAnimalsToTrain("Carnivore small", true, Sizes.S, 1);

            AddAnimalsToTrain("Herbivore large", false, Sizes.B, 2);
            AddAnimalsToTrain("Herbivore medium", false, Sizes.M, 3);
            AddAnimalsToTrain("Herbivore small", false, Sizes.S, 0);


            void AddAnimalsToTrain(string animalType, bool isCarnivore, Sizes size, int count)
            {
                if (isCarnivore)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Carnivore(animalType, size));
                    }
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Herbivore(animalType, size));
                    }
                }
            }


            //Act
            Circus.FindBest();


            //Assert
            Assert.AreEqual(2, Circus.Train.Wagons.Count);


        }

        [TestMethod]
        public void Scenario2()
        {
            //Arrange
            Circus Circus = new Circus();
            AddAnimalsToTrain("Carnivore large", true, Sizes.B, 0);
            AddAnimalsToTrain("Carnivore medium", true, Sizes.M, 0);
            AddAnimalsToTrain("Carnivore small", true, Sizes.S, 1);

            AddAnimalsToTrain("Herbivore large", false, Sizes.B, 1);
            AddAnimalsToTrain("Herbivore medium", false, Sizes.M, 2);
            AddAnimalsToTrain("Herbivore small", false, Sizes.S, 5);


            void AddAnimalsToTrain(string animalType, bool isCarnivore, Sizes size, int count)
            {
                if (isCarnivore)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Carnivore(animalType, size));
                    }
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Herbivore(animalType, size));
                    }
                }
            }


            //Act
            Circus.FindBest();


            //Assert
            Assert.AreEqual(2, Circus.Train.Wagons.Count);


        }

        [TestMethod]
        public void Scenario3()
        {
            //Arrange
            Circus Circus = new Circus();
            AddAnimalsToTrain("Carnivore large", true, Sizes.B, 1);
            AddAnimalsToTrain("Carnivore medium", true, Sizes.M, 1);
            AddAnimalsToTrain("Carnivore small", true, Sizes.S, 1);

            AddAnimalsToTrain("Herbivore large", false, Sizes.B, 1);
            AddAnimalsToTrain("Herbivore medium", false, Sizes.M, 1);
            AddAnimalsToTrain("Herbivore small", false, Sizes.S, 1);


            void AddAnimalsToTrain(string animalType, bool isCarnivore, Sizes size, int count)
            {
                if (isCarnivore)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Carnivore(animalType, size));
                    }
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Herbivore(animalType, size));
                    }
                }
            }


            //Act
            Circus.FindBest();


            //Assert
            Assert.AreEqual(4, Circus.Train.Wagons.Count);


        }

        [TestMethod]
        public void Scenario4()
        {
            //Arrange
            Circus Circus = new Circus();
            AddAnimalsToTrain("Carnivore large", true, Sizes.B, 2);
            AddAnimalsToTrain("Carnivore medium", true, Sizes.M, 1);
            AddAnimalsToTrain("Carnivore small", true, Sizes.S, 1);

            AddAnimalsToTrain("Herbivore large", false, Sizes.B, 1);
            AddAnimalsToTrain("Herbivore medium", false, Sizes.M, 5);
            AddAnimalsToTrain("Herbivore small", false, Sizes.S, 1);

            void AddAnimalsToTrain(string animalType, bool isCarnivore, Sizes size, int count)
            {
                if (isCarnivore)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Carnivore(animalType, size));
                    }
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Herbivore(animalType, size));
                    }
                }
            }

            //Act
            Circus.FindBest();

            //Assert
            Assert.AreEqual(5, Circus.Train.Wagons.Count);

        }

        [TestMethod]
        public void Scenario5()
        {
            //Arrange
            Circus Circus = new Circus();
            AddAnimalsToTrain("Carnivore large", true, Sizes.B, 0);
            AddAnimalsToTrain("Carnivore medium", true, Sizes.M, 0);
            AddAnimalsToTrain("Carnivore small", true, Sizes.S, 1);

            AddAnimalsToTrain("Herbivore large", false, Sizes.B, 2);
            AddAnimalsToTrain("Herbivore medium", false, Sizes.M, 1);
            AddAnimalsToTrain("Herbivore small", false, Sizes.S, 1);

            void AddAnimalsToTrain(string animalType, bool isCarnivore, Sizes size, int count)
            {
                if (isCarnivore)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Carnivore(animalType, size));
                    }
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Herbivore(animalType, size));
                    }
                }
            }

            //Act
            Circus.FindBest();

            //Assert
            Assert.AreEqual(2, Circus.Train.Wagons.Count);

        }

        [TestMethod]
        public void Scenario6()
        {
            //Arrange
            Circus Circus = new Circus();
            AddAnimalsToTrain("Carnivore large", true, Sizes.B, 0);
            AddAnimalsToTrain("Carnivore medium", true, Sizes.M, 0);
            AddAnimalsToTrain("Carnivore small", true, Sizes.S, 3);

            AddAnimalsToTrain("Herbivore large", false, Sizes.B, 3);
            AddAnimalsToTrain("Herbivore medium", false, Sizes.M, 2);
            AddAnimalsToTrain("Herbivore small", false, Sizes.S, 0);

            void AddAnimalsToTrain(string animalType, bool isCarnivore, Sizes size, int count)
            {
                if (isCarnivore)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Carnivore(animalType, size));
                    }
                } else
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Herbivore(animalType, size));
                    }
                }
            }

            //Act
            Circus.FindBest();

            //Assert
            Assert.AreEqual(3, Circus.Train.Wagons.Count);

        }

        [TestMethod]
        public void Scenario7()
        {
            //Arrange
            Circus Circus = new Circus();
            AddAnimalsToTrain("Carnivore large", true, Sizes.B, 3);
            AddAnimalsToTrain("Carnivore medium", true, Sizes.M, 3);
            AddAnimalsToTrain("Carnivore small", true, Sizes.S, 7);

            AddAnimalsToTrain("Herbivore large", false, Sizes.B, 6);
            AddAnimalsToTrain("Herbivore medium", false, Sizes.M, 5);
            AddAnimalsToTrain("Herbivore small", false, Sizes.S, 0);

            void AddAnimalsToTrain(string animalType, bool isCarnivore, Sizes size, int count)
            {
                if (isCarnivore)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Carnivore(animalType, size));
                    }
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Herbivore(animalType, size));
                    }
                }
            }

            //Act
            Circus.FindBest();

            //Assert
            Assert.AreEqual(13, Circus.Train.Wagons.Count);

        }

        [TestMethod]
        public void Scenario8()
        {
            //Arrange
            Circus Circus = new Circus();
            AddAnimalsToTrain("Carnivore large", true, Sizes.B, 0);
            AddAnimalsToTrain("Carnivore medium", true, Sizes.M, 0);
            AddAnimalsToTrain("Carnivore small", true, Sizes.S, 0);

            AddAnimalsToTrain("Herbivore large", false, Sizes.B, 1);
            AddAnimalsToTrain("Herbivore medium", false, Sizes.M, 3);
            AddAnimalsToTrain("Herbivore small", false, Sizes.S, 5);

            void AddAnimalsToTrain(string animalType, bool isCarnivore, Sizes size, int count)
            {
                if (isCarnivore)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Carnivore(animalType, size));
                    }
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Herbivore(animalType, size));
                    }
                }
            }

            //Act
            Circus.FindBest();

            //Assert
            Assert.AreEqual(2, Circus.Train.Wagons.Count);

        }

        [TestMethod]
        public void Scenario9()
        {
            //Arrange
            Circus Circus = new Circus();
            AddAnimalsToTrain("Carnivore large", true, Sizes.B, 2);
            AddAnimalsToTrain("Carnivore medium", true, Sizes.M, 3);
            AddAnimalsToTrain("Carnivore small", true, Sizes.S, 1);

            AddAnimalsToTrain("Herbivore large", false, Sizes.B, 3);
            AddAnimalsToTrain("Herbivore medium", false, Sizes.M, 0);
            AddAnimalsToTrain("Herbivore small", false, Sizes.S, 0);

            void AddAnimalsToTrain(string animalType, bool isCarnivore, Sizes size, int count)
            {
                if (isCarnivore)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Carnivore(animalType, size));
                    }
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Herbivore(animalType, size));
                    }
                }
            }

            //Act
            Circus.FindBest();

            //Assert
            Assert.AreEqual(6, Circus.Train.Wagons.Count);

        }

        [TestMethod]
        public void Scenario10()
        {
            //Arrange
            Circus Circus = new Circus();
            AddAnimalsToTrain("Carnivore large", true, Sizes.B, 2);
            AddAnimalsToTrain("Carnivore medium", true, Sizes.M, 2);
            AddAnimalsToTrain("Carnivore small", true, Sizes.S, 2);

            AddAnimalsToTrain("Herbivore large", false, Sizes.B, 5);
            AddAnimalsToTrain("Herbivore medium", false, Sizes.M, 5);
            AddAnimalsToTrain("Herbivore small", false, Sizes.S, 5);

            void AddAnimalsToTrain(string animalType, bool isCarnivore, Sizes size, int count)
            {
                if (isCarnivore)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Carnivore(animalType, size));
                    }
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Herbivore(animalType, size));
                    }
                }
            }

            //Act
            Circus.FindBest();

            //Assert
            Assert.AreEqual(8, Circus.Train.Wagons.Count);

        }

        [TestMethod]
        public void Scenario11()
        {
            //Arrange
            Circus Circus = new Circus();
            AddAnimalsToTrain("Carnivore large", true, Sizes.B, 0);
            AddAnimalsToTrain("Carnivore medium", true, Sizes.M, 0);
            AddAnimalsToTrain("Carnivore small", true, Sizes.S, 0);

            AddAnimalsToTrain("Herbivore large", false, Sizes.B, 2);
            AddAnimalsToTrain("Herbivore medium", false, Sizes.M, 3);
            AddAnimalsToTrain("Herbivore small", false, Sizes.S, 1);

            void AddAnimalsToTrain(string animalType, bool isCarnivore, Sizes size, int count)
            {
                if (isCarnivore)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Carnivore(animalType, size));
                    }
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Herbivore(animalType, size));
                    }
                }
            }

            //Act
            Circus.FindBest();

            //Assert
            Assert.AreEqual(2, Circus.Train.Wagons.Count);

        }

        [TestMethod]
        public void Scenario12()
        {
            //Arrange
            Circus Circus = new Circus();
            AddAnimalsToTrain("Carnivore large", true, Sizes.B, 0);
            AddAnimalsToTrain("Carnivore medium", true, Sizes.M, 0);
            AddAnimalsToTrain("Carnivore small", true, Sizes.S, 1);

            AddAnimalsToTrain("Herbivore large", false, Sizes.B, 2);
            AddAnimalsToTrain("Herbivore medium", false, Sizes.M, 3);
            AddAnimalsToTrain("Herbivore small", false, Sizes.S, 0);

            void AddAnimalsToTrain(string animalType, bool isCarnivore, Sizes size, int count)
            {
                if (isCarnivore)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Carnivore(animalType, size));
                    }
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Herbivore(animalType, size));
                    }
                }
            }

            //Act
            Circus.FindBest();

            //Assert
            Assert.AreEqual(2, Circus.Train.Wagons.Count);

        }

        [TestMethod]
        public void Scenario13()
        {
            //Arrange
            Circus Circus = new Circus();
            AddAnimalsToTrain("Carnivore large", true, Sizes.B, 0);
            AddAnimalsToTrain("Carnivore medium", true, Sizes.M, 0);
            AddAnimalsToTrain("Carnivore small", true, Sizes.S, 2);

            AddAnimalsToTrain("Herbivore large", false, Sizes.B, 2);
            AddAnimalsToTrain("Herbivore medium", false, Sizes.M, 2);
            AddAnimalsToTrain("Herbivore small", false, Sizes.S, 0);

            void AddAnimalsToTrain(string animalType, bool isCarnivore, Sizes size, int count)
            {
                if (isCarnivore)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Carnivore(animalType, size));
                    }
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Herbivore(animalType, size));
                    }
                }
            }

            //Act
            Circus.FindBest();

            //Assert
            Assert.AreEqual(2, Circus.Train.Wagons.Count);

        }


        [TestMethod]
        public void Scenario14()
        {
            //Arrange
            Circus Circus = new Circus();
            AddAnimalsToTrain("Carnivore large", true, Sizes.B, 0);
            AddAnimalsToTrain("Carnivore medium", true, Sizes.M, 0);
            AddAnimalsToTrain("Carnivore small", true, Sizes.S, 2);

            AddAnimalsToTrain("Herbivore large", false, Sizes.B, 2);
            AddAnimalsToTrain("Herbivore medium", false, Sizes.M, 6);
            AddAnimalsToTrain("Herbivore small", false, Sizes.S, 0);

            void AddAnimalsToTrain(string animalType, bool isCarnivore, Sizes size, int count)
            {
                if (isCarnivore)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Carnivore(animalType, size));
                    }
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        Circus.AddAnimal(new Herbivore(animalType, size));
                    }
                }
            }

            //Act
            Circus.FindBest();

            //Assert
            Assert.AreEqual(3, Circus.Train.Wagons.Count);

        }
    }
}