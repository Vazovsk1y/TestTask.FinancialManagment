﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestTask.Application.Common;
using TestTask.Application.Contracts;
using TestTask.Application.Services;
using TestTask.DAL;
using TestTask.Domain.Constants;
using TestTask.Domain.Entities;
using TestTask.Domain.Enums;

namespace TestTask.Application.Implementation.Services;

internal class MoneyOperationService : BaseService, IMoneyOperationService
{
	private readonly IClock _clock;
	public MoneyOperationService(TestTaskDbContext dbContext, IUserProvider userProvider, IServiceScopeFactory serviceScopeFactory, IClock clock) : base(dbContext, userProvider, serviceScopeFactory)
	{
		_clock = clock;
	}

	public async Task<Result<MoneyOperationId>> EnrollAsync(EnrollDTO enrollDTO, CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
		//var validationResult = Validate(enrollDTO);
		//if (validationResult.IsFailure)
		//{
		//	return Result.Failure<MoneyOperationId>(validationResult.ErrorMessage);
		//}

		//var account = await _dbContext
		//	.MoneyAccounts
		//	.SingleOrDefaultAsync(e => e.Id == enrollDTO.MoneyAccountToId, cancellationToken);

		//if (account is null)
		//{
		//	return Result.Failure<MoneyOperationId>(Errors.EntityWithPassedIdIsNotExists(nameof(MoneyAccount)));
		//}

		//account.Balance += enrollDTO.MoneyAmount;
		//var operation = new MoneyOperation
		//{
		//	MoneyAmount = enrollDTO.MoneyAmount,
		//	MoneyAccountToId = account.Id,
		//	MoveType = MoneyMoveTypes.Adding,
		//	OperationDate = _clock.GetUtcNow(),
		//	OperationType = MoneyOperationTypes.Enrolment,
		//};

		//_dbContext.MoneyOperations.Add(operation);
		//await _dbContext.SaveChangesAsync(cancellationToken);
		//return operation.Id;
	}

	public async Task<Result<IReadOnlyCollection<MoneyOperationDTO>>> GetAllByUserIdAsync(UserId userId, CancellationToken cancellationToken = default)
	{
		var requesterIdResult = _userProvider.GetCurrent();
		if (requesterIdResult.IsFailure)
		{
			return Result.Failure<IReadOnlyCollection<MoneyOperationDTO>>(requesterIdResult.ErrorMessage);
		}

		var requester = await _dbContext
			.Users
			.Include(e => e.Roles)
			.ThenInclude(e => e.Role)
			.GetById(requesterIdResult.Value);

		bool actionPermitted = requester!.IsInRole(DefaultRoles.Admin) || requester!.Id == userId;
		if (!actionPermitted)
		{
			return Result.Failure<IReadOnlyCollection<MoneyOperationDTO>>(Errors.Auth.AccessDenied);
		}

		var accounts =  _dbContext
			.MoneyAccounts
			.AsNoTracking()
			.Where(e => e.UserId == userId)
			.Select(e => e.Id);

		var result = await _dbContext
			.MoneyOperations
			.AsNoTracking()
			.Where(e => accounts.Contains(e.MoneyAccountFromId) || accounts.Contains(e.MoneyAccountToId))
			.Select(e => e.ToDTO())
			.ToListAsync(cancellationToken);


		return result;
	}

	public Task<Result<IReadOnlyCollection<MoneyOperationDTO>>> GetAllByMoneyAccountIdAsync(UserId requesterId, MoneyAccountId moneyAccountId, CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task<Result<MoneyOperationId>> TransferAsync(UserId requesterId, TransferDTO transferDTO, CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task<Result<MoneyOperationId>> WithdrawalAsync(UserId requesterId, WithdrawalDTO withdrawalDTO, CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	//private static Result<decimal> CalculateFinalSum(decimal startAmount, decimal commission, decimal exchangeRate)
	//{
	//	decimal result = 0m;
	//	if (exchangeRate != 0m)
	//	{

	//	}
	//}
}