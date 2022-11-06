﻿/*
	* SPDX-License-Identifier: Apache-2.0
	* Copyright 2021 FINOS FDC3 contributors - see NOTICE file
	*/


using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("Finos.Fdc3.Backplane.Client.Test")]
namespace Finos.Fdc3.Backplane.Client.Transport
{
    internal class SignalRConnection : ISignalRConnection
    {
        private readonly HubConnection _connection;


        public event Func<Exception, Task> Closed
        {
            add
            {
                _connection.Closed += value;
            }
            remove
            {
                _connection.Closed -= value;
            }
        }

        public event Func<string, Task> Reconnected
        {
            add
            {
                _connection.Reconnected += value;
            }
            remove
            {
                _connection.Reconnected -= value;
            }
        }

        public SignalRConnection(HubConnection hubConnection)
        {
            _connection = hubConnection;
        }

        public ConnectionState State => Transform(_connection.State);

        public async Task StartAsync(CancellationToken ct = default)
        {
            await _connection.StartAsync(ct);
        }

        public IDisposable On<T>(string methodName, Action<T> handler)
        {
            return _connection.On(methodName, handler);
        }

        public Task InvokeAsync(string methodName, object arg, CancellationToken cancellationToken = default)
        {
            return _connection.InvokeAsync(methodName, arg, cancellationToken);
        }

        public Task InvokeAsync(string methodName, object arg1, object arg2, CancellationToken cancellationToken = default)
        {
            return _connection.InvokeAsync(methodName, arg1, arg2, cancellationToken);
        }

        public Task<TResult> InvokeAsync<TResult>(string methodName, CancellationToken cancellationToken = default)
        {
            return _connection.InvokeAsync<TResult>(methodName, cancellationToken);
        }

        public Task<TResult> InvokeAsync<TResult>(string methodName, object arg, CancellationToken cancellationToken = default)
        {
            return _connection.InvokeAsync<TResult>(methodName, arg, cancellationToken);
        }

        public ValueTask DisposeAsync()
        {
            return _connection.DisposeAsync();
        }

        private ConnectionState Transform(HubConnectionState hubConnectionState)
        {
            switch (hubConnectionState)
            {
                case HubConnectionState.Connected:
                    return ConnectionState.Connected;
                case HubConnectionState.Connecting:
                    return ConnectionState.Connecting;
                case HubConnectionState.Disconnected:
                    return ConnectionState.Disconnected;
                case HubConnectionState.Reconnecting:
                    return ConnectionState.Reconnecting;
                default:
                    return ConnectionState.Disconnected;
            }
        }

    }
}

