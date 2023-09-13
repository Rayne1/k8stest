// See https://aka.ms/new-console-template for more information
using k8s;

Console.WriteLine("Hello, World!");
await Task.Delay (10);
System.Console.WriteLine("Do request");

var config = KubernetesClientConfiguration.InClusterConfig();
var client = new Kubernetes(config);

var services = await client.ListNamespacedServiceAsync("warranty");
