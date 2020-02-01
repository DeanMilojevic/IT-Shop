// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/customers.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace IT_Shop.Customers.Api.Generated {
  public static partial class CustomersService
  {
    static readonly string __ServiceName = "generated.CustomersService";

    static readonly grpc::Marshaller<global::IT_Shop.Customers.Api.Generated.CustomerQuery> __Marshaller_generated_CustomerQuery = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::IT_Shop.Customers.Api.Generated.CustomerQuery.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::IT_Shop.Customers.Api.Generated.CustomerModel> __Marshaller_generated_CustomerModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::IT_Shop.Customers.Api.Generated.CustomerModel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::IT_Shop.Customers.Api.Generated.BrowseCustomersQuery> __Marshaller_generated_BrowseCustomersQuery = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::IT_Shop.Customers.Api.Generated.BrowseCustomersQuery.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::IT_Shop.Customers.Api.Generated.CustomersModel> __Marshaller_generated_CustomersModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::IT_Shop.Customers.Api.Generated.CustomersModel.Parser.ParseFrom);

    static readonly grpc::Method<global::IT_Shop.Customers.Api.Generated.CustomerQuery, global::IT_Shop.Customers.Api.Generated.CustomerModel> __Method_Get = new grpc::Method<global::IT_Shop.Customers.Api.Generated.CustomerQuery, global::IT_Shop.Customers.Api.Generated.CustomerModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_generated_CustomerQuery,
        __Marshaller_generated_CustomerModel);

    static readonly grpc::Method<global::IT_Shop.Customers.Api.Generated.BrowseCustomersQuery, global::IT_Shop.Customers.Api.Generated.CustomersModel> __Method_GetAll = new grpc::Method<global::IT_Shop.Customers.Api.Generated.BrowseCustomersQuery, global::IT_Shop.Customers.Api.Generated.CustomersModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAll",
        __Marshaller_generated_BrowseCustomersQuery,
        __Marshaller_generated_CustomersModel);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::IT_Shop.Customers.Api.Generated.CustomersReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CustomersService</summary>
    [grpc::BindServiceMethod(typeof(CustomersService), "BindService")]
    public abstract partial class CustomersServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::IT_Shop.Customers.Api.Generated.CustomerModel> Get(global::IT_Shop.Customers.Api.Generated.CustomerQuery request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::IT_Shop.Customers.Api.Generated.CustomersModel> GetAll(global::IT_Shop.Customers.Api.Generated.BrowseCustomersQuery request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CustomersServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Get, serviceImpl.Get)
          .AddMethod(__Method_GetAll, serviceImpl.GetAll).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CustomersServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Get, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::IT_Shop.Customers.Api.Generated.CustomerQuery, global::IT_Shop.Customers.Api.Generated.CustomerModel>(serviceImpl.Get));
      serviceBinder.AddMethod(__Method_GetAll, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::IT_Shop.Customers.Api.Generated.BrowseCustomersQuery, global::IT_Shop.Customers.Api.Generated.CustomersModel>(serviceImpl.GetAll));
    }

  }
}
#endregion
