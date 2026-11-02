var vm = new GradeViewModel(new GradingService(new MemoryGradeStore()));
vm.ScoreText = "10";
vm.Add();
vm.ScoreText = "8";
vm.Add();
Console.WriteLine(vm.AverageText);
