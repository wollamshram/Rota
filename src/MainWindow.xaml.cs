using System;
using System.Collections.Generic;
using System.Linq;
using ZooRota.Domain;

namespace ZooRota
{
    class Person : IPerson
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }

        public Person(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    class Task : ITask
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }

        public Task(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    class TaskSchedule : ITaskSchedule
    {
        public ITask Task { get; private set; }
        public Dictionary<string, List<IPerson> > Shifts { get; private set; }

        public TaskSchedule(ITask task, Dictionary<string, List<IPerson> > shifts)
        {
            Task = task;
            Shifts = shifts;
        }
    }

    public partial class MainWindow
    {
        private readonly static List<IPerson> Persons = new List<IPerson>
        {
            new Person(new Guid(), "Fiona"),
            new Person(new Guid(), "Becky")
        };

        private readonly static List<ITask> Tasks = new List<ITask>
        {
            new Task(new Guid(), "Monkeys"),
            new Task(new Guid(), "Penguins")
        };

        private static readonly List<ITaskSchedule> Schedules = new List<ITaskSchedule>
        {
            new TaskSchedule(Tasks.First(), new Dictionary<string, List<IPerson>>
            {
                {"11:00", new List<IPerson> {Persons.First()}},
                {"12:00", new List<IPerson> {Persons.First(), Persons.Last()}},
                {"13:00", new List<IPerson> {Persons.Last()}}
            }),
            new TaskSchedule(Tasks.Last(), new Dictionary<string, List<IPerson>>
            {
                {"11:00", new List<IPerson> {Persons.First()}},
                {"12:00", new List<IPerson> {Persons.First()}},
                {"13:00", new List<IPerson> {Persons.First()}}
            })
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            LvMain.ItemsSource = Schedules;
        }
    }
}
