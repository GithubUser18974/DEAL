﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Example : MonoBehaviour
{
	[SerializeField] MstItems mstItems;
	[SerializeField] Text text;

	void Start()
	{
		ShowItems();
	}

	void ShowItems()
	{
		string str = "";

		mstItems.Entities
			.ForEach(entity => str += DescribeMstItemEntity(entity) + "\n");

		text.text = str;
	}

	string DescribeMstItemEntity(MstItemEntity entity)
	{
		return string.Format(
			"{0} : {1}, {2}, {3}, {4}, {5}, {6}",
			entity.Code,
			entity.Name,
			entity.Area,
			entity.SalesmanName,
			entity.Shops,
			entity.Date,
			entity.Status
		);
	}
}

