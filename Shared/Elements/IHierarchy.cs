using System;

namespace Shared.Elements
{
	public interface IHierarchy<TElement, TKey> : IElement<TElement, TKey>
		where TKey : unmanaged, IEquatable<TKey>
		where TElement : IElement<TElement, TKey>
	{
	}

	public interface IHierarchy<TElement, TKey,
		THierarchy1, THierarchyKey1,
		THierarchy2, THierarchyKey2>
		: IHierarchy<TElement, TKey>,
			IHierarchyMemberHierarchy1<THierarchy1, THierarchyKey1>,
			IHierarchyMemberHierarchy2<THierarchy2, THierarchyKey2>
		where TKey : unmanaged, IEquatable<TKey>
		where TElement : IElement<TElement, TKey>
		where THierarchyKey1 : unmanaged, IEquatable<THierarchyKey1>
		where THierarchy1 : IHierarchy<THierarchy1, THierarchyKey1>
		where THierarchyKey2 : unmanaged, IEquatable<THierarchyKey2>
		where THierarchy2 : IHierarchy<THierarchy2, THierarchyKey2>
	{
	}

	public interface IHierarchy<TElement, TKey,
		THierarchy1, THierarchyKey1,
		THierarchy2, THierarchyKey2,
		THierarchy3, THierarchyKey3>
		: IHierarchy<TElement, TKey, THierarchy1, THierarchyKey1,THierarchy2, THierarchyKey2>,
			IHierarchyMemberHierarchy1<THierarchy1, THierarchyKey1>,
			IHierarchyMemberHierarchy2<THierarchy2, THierarchyKey2>
		where TKey : unmanaged, IEquatable<TKey>
		where TElement : IElement<TElement, TKey>
		where THierarchyKey1 : unmanaged, IEquatable<THierarchyKey1>
		where THierarchy1 : IHierarchy<THierarchy1, THierarchyKey1>
		where THierarchyKey2 : unmanaged, IEquatable<THierarchyKey2>
		where THierarchy2 : IHierarchy<THierarchy2, THierarchyKey2>
		where THierarchyKey3 : unmanaged, IEquatable<THierarchyKey3>
		where THierarchy3 : IHierarchy<THierarchy3, THierarchyKey3>
	{
	}

	public interface IHierarchy<TElement, TKey,
		TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		: IHierarchy<TElement, TKey>,
			IHierarchyMemberDatumLabel1<TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where TKey : unmanaged, IEquatable<TKey>
		where TElement : IElement<TElement, TKey>
		where TDatumKey1 : unmanaged, IEquatable<TDatumKey1>
		where TDatumLabelKey1 : unmanaged, IEquatable<TDatumLabelKey1>
		where TDatum1 : IDatum<TDatum1, TDatumKey1, TDatumValue1>
		where TDatumLabel1 : IDatumLabel<TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
	{
	}

	public interface IHierarchy<TElement, TKey,
		TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1,
		THierarchy1, THierarchyKey1>
		: IHierarchy<TElement, TKey, TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>,
			IHierarchyMemberDatumLabel1<TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where TKey : unmanaged, IEquatable<TKey>
		where TElement : IElement<TElement, TKey>
		where TDatumKey1 : unmanaged, IEquatable<TDatumKey1>
		where TDatumLabelKey1 : unmanaged, IEquatable<TDatumLabelKey1>
		where TDatum1 : IDatum<TDatum1, TDatumKey1, TDatumValue1>
		where TDatumLabel1 : IDatumLabel<TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where THierarchyKey1 : unmanaged, IEquatable<THierarchyKey1>
		where THierarchy1 : IHierarchy<THierarchy1, THierarchyKey1>
	{
	}

	public interface IHierarchy<TElement, TKey,
		TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1,
		THierarchy1, THierarchyKey1,
		THierarchy2, THierarchyKey2>
		: IHierarchy<TElement, TKey, TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1, THierarchy1, THierarchyKey1>,
			IHierarchyMemberDatumLabel1<TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>,
			IHierarchyMemberHierarchy1<THierarchy1, THierarchyKey1>
		where TKey : unmanaged, IEquatable<TKey>
		where TElement : IElement<TElement, TKey>
		where TDatumKey1 : unmanaged, IEquatable<TDatumKey1>
		where TDatumLabelKey1 : unmanaged, IEquatable<TDatumLabelKey1>
		where TDatum1 : IDatum<TDatum1, TDatumKey1, TDatumValue1>
		where TDatumLabel1 : IDatumLabel<TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where THierarchyKey1 : unmanaged, IEquatable<THierarchyKey1>
		where THierarchy1 : IHierarchy<THierarchy1, THierarchyKey1>
		where THierarchyKey2 : unmanaged, IEquatable<THierarchyKey2>
		where THierarchy2 : IHierarchy<THierarchy2, THierarchyKey2>
	{
	}

	public interface IHierarchy<TElement, TKey,
		TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1,
		THierarchy1, THierarchyKey1,
		THierarchy2, THierarchyKey2,
		THierarchy3, THierarchyKey3>
		: IHierarchy<TElement, TKey, TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1, THierarchy1, THierarchyKey1,THierarchy2, THierarchyKey2>,
			IHierarchyMemberDatumLabel1<TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>,
			IHierarchyMemberHierarchy1<THierarchy1, THierarchyKey1>,
			IHierarchyMemberHierarchy2<THierarchy2, THierarchyKey2>
		where TKey : unmanaged, IEquatable<TKey>
		where TElement : IElement<TElement, TKey>
		where TDatumKey1 : unmanaged, IEquatable<TDatumKey1>
		where TDatumLabelKey1 : unmanaged, IEquatable<TDatumLabelKey1>
		where TDatum1 : IDatum<TDatum1, TDatumKey1, TDatumValue1>
		where TDatumLabel1 : IDatumLabel<TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where THierarchyKey1 : unmanaged, IEquatable<THierarchyKey1>
		where THierarchy1 : IHierarchy<THierarchy1, THierarchyKey1>
		where THierarchyKey2 : unmanaged, IEquatable<THierarchyKey2>
		where THierarchy2 : IHierarchy<THierarchy2, THierarchyKey2>
		where THierarchyKey3 : unmanaged, IEquatable<THierarchyKey3>
		where THierarchy3 : IHierarchy<THierarchy3, THierarchyKey3>
	{
	}

	public interface IHierarchy<TElement, TKey,
		TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1,
		TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2>
		: IHierarchy<TElement, TKey, TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>,
			IHierarchyMemberDatumLabel1<TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where TKey : unmanaged, IEquatable<TKey>
		where TElement : IElement<TElement, TKey>
		where TDatumKey1 : unmanaged, IEquatable<TDatumKey1>
		where TDatumLabelKey1 : unmanaged, IEquatable<TDatumLabelKey1>
		where TDatum1 : IDatum<TDatum1, TDatumKey1, TDatumValue1>
		where TDatumLabel1 : IDatumLabel<TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where TDatumKey2 : unmanaged, IEquatable<TDatumKey2>
		where TDatumLabelKey2 : unmanaged, IEquatable<TDatumLabelKey2>
		where TDatum2 : IDatum<TDatum2, TDatumKey2, TDatumValue2>
		where TDatumLabel2 : IDatumLabel<TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2>
	{
	}

	public interface IHierarchy<TElement, TKey,
		TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1,
		TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2,
		THierarchy1, THierarchyKey1>
		: IHierarchy<TElement, TKey, TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1, THierarchy1, THierarchyKey1>,
			IHierarchyMemberDatumLabel1<TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>,
			IHierarchyMemberHierarchy1<THierarchy1, THierarchyKey1>
		where TKey : unmanaged, IEquatable<TKey>
		where TElement : IElement<TElement, TKey>
		where TDatumKey1 : unmanaged, IEquatable<TDatumKey1>
		where TDatumLabelKey1 : unmanaged, IEquatable<TDatumLabelKey1>
		where TDatum1 : IDatum<TDatum1, TDatumKey1, TDatumValue1>
		where TDatumLabel1 : IDatumLabel<TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where TDatumKey2 : unmanaged, IEquatable<TDatumKey2>
		where TDatumLabelKey2 : unmanaged, IEquatable<TDatumLabelKey2>
		where TDatum2 : IDatum<TDatum2, TDatumKey2, TDatumValue2>
		where TDatumLabel2 : IDatumLabel<TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2>
		where THierarchyKey1 : unmanaged, IEquatable<THierarchyKey1>
		where THierarchy1 : IHierarchy<THierarchy1, THierarchyKey1>
	{
	}

	public interface IHierarchy<TElement, TKey,
		TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1,
		TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2,
		THierarchy1, THierarchyKey1,
		THierarchy2, THierarchyKey2>
		: IHierarchy<TElement, TKey, TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1, TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2, THierarchy1, THierarchyKey1>,
			IHierarchyMemberDatumLabel1<TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>,
			IHierarchyMemberDatumLabel2<TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2>,
			IHierarchyMemberHierarchy1<THierarchy1, THierarchyKey1>
		where TKey : unmanaged, IEquatable<TKey>
		where TElement : IElement<TElement, TKey>
		where TDatumKey1 : unmanaged, IEquatable<TDatumKey1>
		where TDatumLabelKey1 : unmanaged, IEquatable<TDatumLabelKey1>
		where TDatum1 : IDatum<TDatum1, TDatumKey1, TDatumValue1>
		where TDatumLabel1 : IDatumLabel<TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where TDatumKey2 : unmanaged, IEquatable<TDatumKey2>
		where TDatumLabelKey2 : unmanaged, IEquatable<TDatumLabelKey2>
		where TDatum2 : IDatum<TDatum2, TDatumKey2, TDatumValue2>
		where TDatumLabel2 : IDatumLabel<TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2>
		where THierarchyKey1 : unmanaged, IEquatable<THierarchyKey1>
		where THierarchy1 : IHierarchy<THierarchy1, THierarchyKey1>
		where THierarchyKey2 : unmanaged, IEquatable<THierarchyKey2>
		where THierarchy2 : IHierarchy<THierarchy2, THierarchyKey2>
	{
	}

	public interface IHierarchy<TElement, TKey,
		TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1,
		TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2,
		THierarchy1, THierarchyKey1,
		THierarchy2, THierarchyKey2,
		THierarchy3, THierarchyKey3>
		: IHierarchy<TElement, TKey, TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1, TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2, THierarchy1, THierarchyKey1,THierarchy2, THierarchyKey2>,
			IHierarchyMemberDatumLabel1<TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>,
			IHierarchyMemberDatumLabel2<TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2>,
			IHierarchyMemberHierarchy1<THierarchy1, THierarchyKey1>,
			IHierarchyMemberHierarchy2<THierarchy2, THierarchyKey2>
		where TKey : unmanaged, IEquatable<TKey>
		where TElement : IElement<TElement, TKey>
		where TDatumKey1 : unmanaged, IEquatable<TDatumKey1>
		where TDatumLabelKey1 : unmanaged, IEquatable<TDatumLabelKey1>
		where TDatum1 : IDatum<TDatum1, TDatumKey1, TDatumValue1>
		where TDatumLabel1 : IDatumLabel<TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where TDatumKey2 : unmanaged, IEquatable<TDatumKey2>
		where TDatumLabelKey2 : unmanaged, IEquatable<TDatumLabelKey2>
		where TDatum2 : IDatum<TDatum2, TDatumKey2, TDatumValue2>
		where TDatumLabel2 : IDatumLabel<TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2>
		where THierarchyKey1 : unmanaged, IEquatable<THierarchyKey1>
		where THierarchy1 : IHierarchy<THierarchy1, THierarchyKey1>
		where THierarchyKey2 : unmanaged, IEquatable<THierarchyKey2>
		where THierarchy2 : IHierarchy<THierarchy2, THierarchyKey2>
		where THierarchyKey3 : unmanaged, IEquatable<THierarchyKey3>
		where THierarchy3 : IHierarchy<THierarchy3, THierarchyKey3>
	{
	}

	public interface IHierarchy<TElement, TKey,
		TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1,
		TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2,
		TDatumLabel3, TDatumLabelKey3, TDatum3, TDatumKey3, TDatumValue3>
		: IHierarchy<TElement, TKey, TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1,TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2>,
			IHierarchyMemberDatumLabel1<TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>,
			IHierarchyMemberDatumLabel2<TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2>
		where TKey : unmanaged, IEquatable<TKey>
		where TElement : IElement<TElement, TKey>
		where TDatumKey1 : unmanaged, IEquatable<TDatumKey1>
		where TDatumLabelKey1 : unmanaged, IEquatable<TDatumLabelKey1>
		where TDatum1 : IDatum<TDatum1, TDatumKey1, TDatumValue1>
		where TDatumLabel1 : IDatumLabel<TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where TDatumKey2 : unmanaged, IEquatable<TDatumKey2>
		where TDatumLabelKey2 : unmanaged, IEquatable<TDatumLabelKey2>
		where TDatum2 : IDatum<TDatum2, TDatumKey2, TDatumValue2>
		where TDatumLabel2 : IDatumLabel<TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2>
		where TDatumKey3 : unmanaged, IEquatable<TDatumKey3>
		where TDatumLabelKey3 : unmanaged, IEquatable<TDatumLabelKey3>
		where TDatum3 : IDatum<TDatum3, TDatumKey3, TDatumValue3>
		where TDatumLabel3 : IDatumLabel<TDatumLabel3, TDatumLabelKey3, TDatum3, TDatumKey3, TDatumValue3>
	{
	}

	public interface IHierarchy<TElement, TKey,
		TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1,
		TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2,
		TDatumLabel3, TDatumLabelKey3, TDatum3, TDatumKey3, TDatumValue3,
		THierarchy1, THierarchyKey1>
		: IHierarchy<TElement, TKey, TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1, TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2, THierarchy1, THierarchyKey1>,
			IHierarchyMemberDatumLabel1<TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>,
			IHierarchyMemberDatumLabel2<TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2>,
			IHierarchyMemberHierarchy1<THierarchy1, THierarchyKey1>
		where TKey : unmanaged, IEquatable<TKey>
		where TElement : IElement<TElement, TKey>
		where TDatumKey1 : unmanaged, IEquatable<TDatumKey1>
		where TDatumLabelKey1 : unmanaged, IEquatable<TDatumLabelKey1>
		where TDatum1 : IDatum<TDatum1, TDatumKey1, TDatumValue1>
		where TDatumLabel1 : IDatumLabel<TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where TDatumKey2 : unmanaged, IEquatable<TDatumKey2>
		where TDatumLabelKey2 : unmanaged, IEquatable<TDatumLabelKey2>
		where TDatum2 : IDatum<TDatum2, TDatumKey2, TDatumValue2>
		where TDatumLabel2 : IDatumLabel<TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2>
		where TDatumKey3 : unmanaged, IEquatable<TDatumKey3>
		where TDatumLabelKey3 : unmanaged, IEquatable<TDatumLabelKey3>
		where TDatum3 : IDatum<TDatum3, TDatumKey3, TDatumValue3>
		where TDatumLabel3 : IDatumLabel<TDatumLabel3, TDatumLabelKey3, TDatum3, TDatumKey3, TDatumValue3>
		where THierarchyKey1 : unmanaged, IEquatable<THierarchyKey1>
		where THierarchy1 : IHierarchy<THierarchy1, THierarchyKey1>
	{
	}

	public interface IHierarchy<TElement, TKey,
		TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1,
		TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2,
		TDatumLabel3, TDatumLabelKey3, TDatum3, TDatumKey3, TDatumValue3,
		THierarchy1, THierarchyKey1,
		THierarchy2, THierarchyKey2>
		: IHierarchy<TElement, TKey, TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1, TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2, THierarchy1, THierarchyKey1,THierarchy2, THierarchyKey2>,
			IHierarchyMemberDatumLabel1<TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>,
			IHierarchyMemberDatumLabel2<TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2>,
			IHierarchyMemberHierarchy1<THierarchy1, THierarchyKey1>,
			IHierarchyMemberHierarchy2<THierarchy2, THierarchyKey2>
		where TKey : unmanaged, IEquatable<TKey>
		where TElement : IElement<TElement, TKey>
		where TDatumKey1 : unmanaged, IEquatable<TDatumKey1>
		where TDatumLabelKey1 : unmanaged, IEquatable<TDatumLabelKey1>
		where TDatum1 : IDatum<TDatum1, TDatumKey1, TDatumValue1>
		where TDatumLabel1 : IDatumLabel<TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where TDatumKey2 : unmanaged, IEquatable<TDatumKey2>
		where TDatumLabelKey2 : unmanaged, IEquatable<TDatumLabelKey2>
		where TDatum2 : IDatum<TDatum2, TDatumKey2, TDatumValue2>
		where TDatumLabel2 : IDatumLabel<TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2>
		where TDatumKey3 : unmanaged, IEquatable<TDatumKey3>
		where TDatumLabelKey3 : unmanaged, IEquatable<TDatumLabelKey3>
		where TDatum3 : IDatum<TDatum3, TDatumKey3, TDatumValue3>
		where TDatumLabel3 : IDatumLabel<TDatumLabel3, TDatumLabelKey3, TDatum3, TDatumKey3, TDatumValue3>
		where THierarchyKey1 : unmanaged, IEquatable<THierarchyKey1>
		where THierarchy1 : IHierarchy<THierarchy1, THierarchyKey1>
		where THierarchyKey2 : unmanaged, IEquatable<THierarchyKey2>
		where THierarchy2 : IHierarchy<THierarchy2, THierarchyKey2>
	{
	}

	public interface IHierarchy<TElement, TKey,
		TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1,
		TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2,
		TDatumLabel3, TDatumLabelKey3, TDatum3, TDatumKey3, TDatumValue3,
		THierarchy1, THierarchyKey1,
		THierarchy2, THierarchyKey2,
		THierarchy3, THierarchyKey3>
		: IHierarchy<TElement, TKey, TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1, TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2, TDatumLabel3, TDatumLabelKey3, TDatum3, TDatumKey3, TDatumValue3, THierarchy1, THierarchyKey1,THierarchy2, THierarchyKey2>,
			IHierarchyMemberDatumLabel1<TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>,
			IHierarchyMemberDatumLabel2<TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2>,
			IHierarchyMemberDatumLabel3<TDatumLabel3, TDatumLabelKey3, TDatum3, TDatumKey3, TDatumValue3>,
			IHierarchyMemberHierarchy1<THierarchy1, THierarchyKey1>,
			IHierarchyMemberHierarchy2<THierarchy2, THierarchyKey2>
		where TKey : unmanaged, IEquatable<TKey>
		where TElement : IElement<TElement, TKey>
		where TDatumKey1 : unmanaged, IEquatable<TDatumKey1>
		where TDatumLabelKey1 : unmanaged, IEquatable<TDatumLabelKey1>
		where TDatum1 : IDatum<TDatum1, TDatumKey1, TDatumValue1>
		where TDatumLabel1 : IDatumLabel<TDatumLabel1, TDatumLabelKey1, TDatum1, TDatumKey1, TDatumValue1>
		where TDatumKey2 : unmanaged, IEquatable<TDatumKey2>
		where TDatumLabelKey2 : unmanaged, IEquatable<TDatumLabelKey2>
		where TDatum2 : IDatum<TDatum2, TDatumKey2, TDatumValue2>
		where TDatumLabel2 : IDatumLabel<TDatumLabel2, TDatumLabelKey2, TDatum2, TDatumKey2, TDatumValue2>
		where TDatumKey3 : unmanaged, IEquatable<TDatumKey3>
		where TDatumLabelKey3 : unmanaged, IEquatable<TDatumLabelKey3>
		where TDatum3 : IDatum<TDatum3, TDatumKey3, TDatumValue3>
		where TDatumLabel3 : IDatumLabel<TDatumLabel3, TDatumLabelKey3, TDatum3, TDatumKey3, TDatumValue3>
		where THierarchyKey1 : unmanaged, IEquatable<THierarchyKey1>
		where THierarchy1 : IHierarchy<THierarchy1, THierarchyKey1>
		where THierarchyKey2 : unmanaged, IEquatable<THierarchyKey2>
		where THierarchy2 : IHierarchy<THierarchy2, THierarchyKey2>
		where THierarchyKey3 : unmanaged, IEquatable<THierarchyKey3>
		where THierarchy3 : IHierarchy<THierarchy3, THierarchyKey3>
	{
	}

	public interface IHierarchyMemberDatumLabel1<TDatumLabel, TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
		where TDatumKey : unmanaged, IEquatable<TDatumKey>
		where TDatumLabelKey : unmanaged, IEquatable<TDatumLabelKey>
		where TDatum : IDatum<TDatum, TDatumKey, TDatumValue>
		where TDatumLabel : IDatumLabel<TDatumLabel, TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
	{
		TDatumLabel Label1 { get; }
		TDatumLabelKey Label1Id { get; }
	}

	public interface IHierarchyMemberDatumLabel2<TDatumLabel, TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
		where TDatumKey : unmanaged, IEquatable<TDatumKey>
		where TDatumLabelKey : unmanaged, IEquatable<TDatumLabelKey>
		where TDatum : IDatum<TDatum, TDatumKey, TDatumValue>
		where TDatumLabel : IDatumLabel<TDatumLabel, TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
	{
		TDatumLabel Label2 { get; }
		TDatumLabelKey Label2Id { get; }
	}

	public interface IHierarchyMemberDatumLabel3<TDatumLabel, TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
		where TDatumKey : unmanaged, IEquatable<TDatumKey>
		where TDatumLabelKey : unmanaged, IEquatable<TDatumLabelKey>
		where TDatum : IDatum<TDatum, TDatumKey, TDatumValue>
		where TDatumLabel : IDatumLabel<TDatumLabel, TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
	{
		TDatumLabel Label3 { get; }
		TDatumLabelKey Label3Id { get; }
	}

	public interface IHierarchyMemberHierarchy1<THierarchy, THierarchyKey>
		where THierarchyKey : unmanaged, IEquatable<THierarchyKey>
		where THierarchy : IHierarchy<THierarchy, THierarchyKey>
	{
		THierarchy Hierarchy1 { get; }
		THierarchyKey Hierarchy1Id { get; }
	}

	public interface IHierarchyMemberHierarchy2<THierarchy, THierarchyKey>
		where THierarchyKey : unmanaged, IEquatable<THierarchyKey>
		where THierarchy : IHierarchy<THierarchy, THierarchyKey>
	{
		THierarchy Hierarchy2 { get; }
		THierarchyKey Hierarchy2Id { get; }
	}

	public interface IHierarchyMemberHierarchy3<THierarchy, THierarchyKey>
		where THierarchyKey : unmanaged, IEquatable<THierarchyKey>
		where THierarchy : IHierarchy<THierarchy, THierarchyKey>
	{
		THierarchy Hierarchy3 { get; }
		THierarchyKey Hierarchy3Id { get; }
	}
}
