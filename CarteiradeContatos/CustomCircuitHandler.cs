using Microsoft.AspNetCore.Components.Server.Circuits;
using System.Collections.Concurrent;

public class CustomCircuitHandler : CircuitHandler
{
    private readonly ConcurrentDictionary<string, Circuit> _circuits = new ConcurrentDictionary<string, Circuit>();

    public override Task OnCircuitOpenedAsync(Circuit circuit, CancellationToken cancellationToken)
    {
        _circuits[circuit.Id] = circuit;
        return Task.CompletedTask;
    }

    public override Task OnCircuitClosedAsync(Circuit circuit, CancellationToken cancellationToken)
    {
        _circuits.TryRemove(circuit.Id, out _);
        return Task.CompletedTask;
    }

    public override Task OnConnectionUpAsync(Circuit circuit, CancellationToken cancellationToken)
    {
        // Lógica adicional quando a conexão é estabelecida
        return Task.CompletedTask;
    }

    public override Task OnConnectionDownAsync(Circuit circuit, CancellationToken cancellationToken)
    {
        // Lógica adicional quando a conexão é perdida
        return Task.CompletedTask;
    }

    public IEnumerable<Circuit> GetActiveCircuits() => _circuits.Values;
}
