using System;
using System.Collections.Generic;

namespace Decorator
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 指摘のリストを作成
            var issues = new List<Issue>
            {
                new Issue{Id = "1",Importance = Importance.High,Priority = Priority.High},
                new Issue{Id = "2",Importance = Importance.High,Priority = Priority.Middle},
                new Issue{Id = "3",Importance = Importance.High,Priority = Priority.Low},
                new Issue{Id = "4",Importance = Importance.Middle,Priority = Priority.High},
                new Issue{Id = "5",Importance = Importance.Middle,Priority = Priority.Middle},
                new Issue{Id = "6",Importance = Importance.Middle,Priority = Priority.Low},
                new Issue{Id = "7",Importance = Importance.Low,Priority = Priority.High},
                new Issue{Id = "8",Importance = Importance.Low,Priority = Priority.Middle},
                new Issue{Id = "9",Importance = Importance.Low,Priority = Priority.Low},
                new Issue{Id = "10",Importance = Importance.Low,Priority = Priority.Low},
            };

            // Decoratorパターンを使って、IssueComparerを作成
            var idComparer = new IssueIDComparer();
            var importanceComparer = new IssueImportanceComparer(idComparer);
            var priorityComparer = new IssuePriorityComparer(importanceComparer);

            // 指摘を重大度でソート
            issues.Sort(priorityComparer);

            // 指摘を表示
            foreach (var issue in issues)
            {
                Console.WriteLine($"ID:{issue.Id},重大度:{issue.Importance},優先度:{issue.Priority}");
            }

            Console.ReadLine();


        }
    }
}