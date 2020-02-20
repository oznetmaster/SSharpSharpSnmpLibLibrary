namespace Lextm.SharpSnmpLib.Pipeline
	{
	internal interface IScalarObject
		{
		/// <summary>
		/// Gets the variable.
		/// </summary>
		/// <value>The variable.</value>
		Variable Variable { get; }

		/// <summary>
		/// Gets or sets the data.
		/// </summary>
		/// <value>The data.</value>
		ISnmpData Data { get; set; }

		/// <summary>
		/// Matches the GET NEXT criteria.
		/// </summary>
		/// <param name="id">The ID in GET NEXT message.</param>
		/// <returns><c>null</c> if it does not match.</returns>
		ScalarObject MatchGetNext (ObjectIdentifier id);

		/// <summary>
		/// Matches the GET criteria.
		/// </summary>
		/// <param name="id">The ID in GET message.</param>
		/// <returns><c>null</c> if it does not match.</returns>
		ScalarObject MatchGet (ObjectIdentifier id);
		}
	}