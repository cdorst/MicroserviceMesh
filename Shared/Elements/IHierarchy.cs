namespace Shared.Elements
{
	public interface IHierarchy<TKey> : IElement<TKey>
		where TKey : unmanaged
	{
	}

	public interface IHierarchy<TKey,
		THierarchy1, THierarchyKey1,
		THierarchy2, THierarchyKey2>
		: IHierarchy<TKey>
		where TKey : unmanaged
		where THierarchyKey1 : unmanaged
		where THierarchy1 : IHierarchy<THierarchyKey1>
		where THierarchyKey2 : unmanaged
		where THierarchy2 : IHierarchy<THierarchyKey2>
	{
	}

	public interface IHierarchy<TKey,
		THierarchy1, THierarchyKey1,
		THierarchy2, THierarchyKey2,
		THierarchy3, THierarchyKey3>
		: IHierarchy<TKey, THierarchy1, THierarchyKey1,THierarchy2, THierarchyKey2>
		where TKey : unmanaged
		where THierarchyKey1 : unmanaged
		where THierarchy1 : IHierarchy<THierarchyKey1>
		where THierarchyKey2 : unmanaged
		where THierarchy2 : IHierarchy<THierarchyKey2>
		where THierarchyKey3 : unmanaged
		where THierarchy3 : IHierarchy<THierarchyKey3>
	{
	}

	public interface IHierarchy<TKey,
		TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		: IHierarchy<TKey>
		where TKey : unmanaged
		where TDatumKey1 : unmanaged
		where TDatumLabelKey1 : unmanaged
		where TDatum1 : IDatum<TDatumKey1, TDatumValue1>
		where TDatumLabel1 : IDatumLabel<TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
	{
	}

	public interface IHierarchy<TKey,
		TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1,
		THierarchy1, THierarchyKey1>
		: IHierarchy<TKey, TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where TKey : unmanaged
		where TDatumKey1 : unmanaged
		where TDatumLabelKey1 : unmanaged
		where TDatum1 : IDatum<TDatumKey1, TDatumValue1>
		where TDatumLabel1 : IDatumLabel<TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where THierarchyKey1 : unmanaged
		where THierarchy1 : IHierarchy<THierarchyKey1>
	{
	}

	public interface IHierarchy<TKey,
		TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1,
		THierarchy1, THierarchyKey1,
		THierarchy2, THierarchyKey2>
		: IHierarchy<TKey, TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1, THierarchy1, THierarchyKey1>
		where TKey : unmanaged
		where TDatumKey1 : unmanaged
		where TDatumLabelKey1 : unmanaged
		where TDatum1 : IDatum<TDatumKey1, TDatumValue1>
		where TDatumLabel1 : IDatumLabel<TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where THierarchyKey1 : unmanaged
		where THierarchy1 : IHierarchy<THierarchyKey1>
		where THierarchyKey2 : unmanaged
		where THierarchy2 : IHierarchy<THierarchyKey2>
	{
	}

	public interface IHierarchy<TKey,
		TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1,
		THierarchy1, THierarchyKey1,
		THierarchy2, THierarchyKey2,
		THierarchy3, THierarchyKey3>
		: IHierarchy<TKey, TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1, THierarchy1, THierarchyKey1,THierarchy2, THierarchyKey2>
		where TKey : unmanaged
		where TDatumKey1 : unmanaged
		where TDatumLabelKey1 : unmanaged
		where TDatum1 : IDatum<TDatumKey1, TDatumValue1>
		where TDatumLabel1 : IDatumLabel<TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where THierarchyKey1 : unmanaged
		where THierarchy1 : IHierarchy<THierarchyKey1>
		where THierarchyKey2 : unmanaged
		where THierarchy2 : IHierarchy<THierarchyKey2>
		where THierarchyKey3 : unmanaged
		where THierarchy3 : IHierarchy<THierarchyKey3>
	{
	}

	public interface IHierarchy<TKey,
		TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1,
		TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2>
		: IHierarchy<TKey, TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where TKey : unmanaged
		where TDatumKey1 : unmanaged
		where TDatumLabelKey1 : unmanaged
		where TDatum1 : IDatum<TDatumKey1, TDatumValue1>
		where TDatumLabel1 : IDatumLabel<TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where TDatumKey2 : unmanaged
		where TDatumLabelKey2 : unmanaged
		where TDatum2 : IDatum<TDatumKey2, TDatumValue2>
		where TDatumLabel2 : IDatumLabel<TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2>
	{
	}

	public interface IHierarchy<TKey,
		TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1,
		TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2,
		THierarchy1, THierarchyKey1>
		: IHierarchy<TKey, TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1, THierarchy1, THierarchyKey1>
		where TKey : unmanaged
		where TDatumKey1 : unmanaged
		where TDatumLabelKey1 : unmanaged
		where TDatum1 : IDatum<TDatumKey1, TDatumValue1>
		where TDatumLabel1 : IDatumLabel<TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where TDatumKey2 : unmanaged
		where TDatumLabelKey2 : unmanaged
		where TDatum2 : IDatum<TDatumKey2, TDatumValue2>
		where TDatumLabel2 : IDatumLabel<TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2>
		where THierarchyKey1 : unmanaged
		where THierarchy1 : IHierarchy<THierarchyKey1>
	{
	}

	public interface IHierarchy<TKey,
		TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1,
		TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2,
		THierarchy1, THierarchyKey1,
		THierarchy2, THierarchyKey2>
		: IHierarchy<TKey, TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1, TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2, THierarchy1, THierarchyKey1>
		where TKey : unmanaged
		where TDatumKey1 : unmanaged
		where TDatumLabelKey1 : unmanaged
		where TDatum1 : IDatum<TDatumKey1, TDatumValue1>
		where TDatumLabel1 : IDatumLabel<TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where TDatumKey2 : unmanaged
		where TDatumLabelKey2 : unmanaged
		where TDatum2 : IDatum<TDatumKey2, TDatumValue2>
		where TDatumLabel2 : IDatumLabel<TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2>
		where THierarchyKey1 : unmanaged
		where THierarchy1 : IHierarchy<THierarchyKey1>
		where THierarchyKey2 : unmanaged
		where THierarchy2 : IHierarchy<THierarchyKey2>
	{
	}

	public interface IHierarchy<TKey,
		TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1,
		TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2,
		THierarchy1, THierarchyKey1,
		THierarchy2, THierarchyKey2,
		THierarchy3, THierarchyKey3>
		: IHierarchy<TKey, TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1, TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2, THierarchy1, THierarchyKey1,THierarchy2, THierarchyKey2>
		where TKey : unmanaged
		where TDatumKey1 : unmanaged
		where TDatumLabelKey1 : unmanaged
		where TDatum1 : IDatum<TDatumKey1, TDatumValue1>
		where TDatumLabel1 : IDatumLabel<TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where TDatumKey2 : unmanaged
		where TDatumLabelKey2 : unmanaged
		where TDatum2 : IDatum<TDatumKey2, TDatumValue2>
		where TDatumLabel2 : IDatumLabel<TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2>
		where THierarchyKey1 : unmanaged
		where THierarchy1 : IHierarchy<THierarchyKey1>
		where THierarchyKey2 : unmanaged
		where THierarchy2 : IHierarchy<THierarchyKey2>
		where THierarchyKey3 : unmanaged
		where THierarchy3 : IHierarchy<THierarchyKey3>
	{
	}

	public interface IHierarchy<TKey,
		TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1,
		TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2,
		TDatumLabel3, TDatumLabelKey3, TDatum3, TDatumKey3, TDatumValue3>
		: IHierarchy<TKey, TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1,TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2>
		where TKey : unmanaged
		where TDatumKey1 : unmanaged
		where TDatumLabelKey1 : unmanaged
		where TDatum1 : IDatum<TDatumKey1, TDatumValue1>
		where TDatumLabel1 : IDatumLabel<TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where TDatumKey2 : unmanaged
		where TDatumLabelKey2 : unmanaged
		where TDatum2 : IDatum<TDatumKey2, TDatumValue2>
		where TDatumLabel2 : IDatumLabel<TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2>
		where TDatumKey3 : unmanaged
		where TDatumLabelKey3 : unmanaged
		where TDatum3 : IDatum<TDatumKey3, TDatumValue3>
		where TDatumLabel3 : IDatumLabel<TDatumLabelKey3, TDatum3, TDatumKey3, TDatumValue3>
	{
	}

	public interface IHierarchy<TKey,
		TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1,
		TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2,
		TDatumLabel3, TDatumLabelKey3, TDatum3, TDatumKey3, TDatumValue3,
		THierarchy1, THierarchyKey1>
		: IHierarchy<TKey, TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1, TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2, THierarchy1, THierarchyKey1>
		where TKey : unmanaged
		where TDatumKey1 : unmanaged
		where TDatumLabelKey1 : unmanaged
		where TDatum1 : IDatum<TDatumKey1, TDatumValue1>
		where TDatumLabel1 : IDatumLabel<TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where TDatumKey2 : unmanaged
		where TDatumLabelKey2 : unmanaged
		where TDatum2 : IDatum<TDatumKey2, TDatumValue2>
		where TDatumLabel2 : IDatumLabel<TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2>
		where TDatumKey3 : unmanaged
		where TDatumLabelKey3 : unmanaged
		where TDatum3 : IDatum<TDatumKey3, TDatumValue3>
		where TDatumLabel3 : IDatumLabel<TDatumLabelKey3, TDatum3, TDatumKey3, TDatumValue3>
		where THierarchyKey1 : unmanaged
		where THierarchy1 : IHierarchy<THierarchyKey1>
	{
	}

	public interface IHierarchy<TKey,
		TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1,
		TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2,
		TDatumLabel3, TDatumLabelKey3, TDatum3, TDatumKey3, TDatumValue3,
		THierarchy1, THierarchyKey1,
		THierarchy2, THierarchyKey2>
		: IHierarchy<TKey, TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1, TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2, THierarchy1, THierarchyKey1,THierarchy2, THierarchyKey2>
		where TKey : unmanaged
		where TDatumKey1 : unmanaged
		where TDatumLabelKey1 : unmanaged
		where TDatum1 : IDatum<TDatumKey1, TDatumValue1>
		where TDatumLabel1 : IDatumLabel<TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where TDatumKey2 : unmanaged
		where TDatumLabelKey2 : unmanaged
		where TDatum2 : IDatum<TDatumKey2, TDatumValue2>
		where TDatumLabel2 : IDatumLabel<TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2>
		where TDatumKey3 : unmanaged
		where TDatumLabelKey3 : unmanaged
		where TDatum3 : IDatum<TDatumKey3, TDatumValue3>
		where TDatumLabel3 : IDatumLabel<TDatumLabelKey3, TDatum3, TDatumKey3, TDatumValue3>
		where THierarchyKey1 : unmanaged
		where THierarchy1 : IHierarchy<THierarchyKey1>
		where THierarchyKey2 : unmanaged
		where THierarchy2 : IHierarchy<THierarchyKey2>
	{
	}

	public interface IHierarchy<TKey,
		TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1,
		TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2,
		TDatumLabel3, TDatumLabelKey3, TDatum3, TDatumKey3, TDatumValue3,
		THierarchy1, THierarchyKey1,
		THierarchy2, THierarchyKey2,
		THierarchy3, THierarchyKey3>
		: IHierarchy<TKey, TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1, TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2, TDatumLabel3, TDatumLabelKey3, TDatum3, TDatumKey3, TDatumValue3, THierarchy1, THierarchyKey1,THierarchy2, THierarchyKey2>
		where TKey : unmanaged
		where TDatumKey1 : unmanaged
		where TDatumLabelKey1 : unmanaged
		where TDatum1 : IDatum<TDatumKey1, TDatumValue1>
		where TDatumLabel1 : IDatumLabel<TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where TDatumKey2 : unmanaged
		where TDatumLabelKey2 : unmanaged
		where TDatum2 : IDatum<TDatumKey2, TDatumValue2>
		where TDatumLabel2 : IDatumLabel<TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2>
		where TDatumKey3 : unmanaged
		where TDatumLabelKey3 : unmanaged
		where TDatum3 : IDatum<TDatumKey3, TDatumValue3>
		where TDatumLabel3 : IDatumLabel<TDatumLabelKey3, TDatum3, TDatumKey3, TDatumValue3>
		where THierarchyKey1 : unmanaged
		where THierarchy1 : IHierarchy<THierarchyKey1>
		where THierarchyKey2 : unmanaged
		where THierarchy2 : IHierarchy<THierarchyKey2>
		where THierarchyKey3 : unmanaged
		where THierarchy3 : IHierarchy<THierarchyKey3>
	{
	}

	public interface IHierarchyMemberDatumLabel1<TDatumLabel, TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
		where TDatumKey : unmanaged
		where TDatumLabelKey : unmanaged
		where TDatum : IDatum<TDatumKey, TDatumValue>
		where TDatumLabel : IDatumLabel<TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
	{
		TDatumLabel Label1 { get; }
		TDatumLabelKey Label1Id { get; }
	}

	public interface IHierarchyMemberDatumLabel2<TDatumLabel, TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
		where TDatumKey : unmanaged
		where TDatumLabelKey : unmanaged
		where TDatum : IDatum<TDatumKey, TDatumValue>
		where TDatumLabel : IDatumLabel<TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
	{
		TDatumLabel Label2 { get; }
		TDatumLabelKey Label2Id { get; }
	}

	public interface IHierarchyMemberDatumLabel3<TDatumLabel, TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
		where TDatumKey : unmanaged
		where TDatumLabelKey : unmanaged
		where TDatum : IDatum<TDatumKey, TDatumValue>
		where TDatumLabel : IDatumLabel<TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
	{
		TDatumLabel Label3 { get; }
		TDatumLabelKey Label3Id { get; }
	}

	public interface IHierarchyMemberHierarchy1<THierarchy, THierarchyKey>
		where THierarchyKey : unmanaged
		where THierarchy : IHierarchy<THierarchyKey>
	{
		THierarchy Hierarchy1 { get; }
		THierarchyKey Hierarchy1Id { get; }
	}

	public interface IHierarchyMemberHierarchy2<THierarchy, THierarchyKey>
		where THierarchyKey : unmanaged
		where THierarchy : IHierarchy<THierarchyKey>
	{
		THierarchy Hierarchy2 { get; }
		THierarchyKey Hierarchy2Id { get; }
	}

	public interface IHierarchyMemberHierarchy3<THierarchy, THierarchyKey>
		where THierarchyKey : unmanaged
		where THierarchy : IHierarchy<THierarchyKey>
	{
		THierarchy Hierarchy3 { get; }
		THierarchyKey Hierarchy3Id { get; }
	}

}
