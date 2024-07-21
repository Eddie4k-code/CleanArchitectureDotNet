using System.Reflection.Metadata.Ecma335;
using HRManagement.Application.Contracts.Persistence;
using HRManagement.Application.Queries.LeaveType.GetLeaveTypeDetails;
using HRManagement.Domain;
using Moq;

namespace HRManagement.Application.UnitTests {

    public class MockLeaveTypeRepository {

        public static Mock<ILeaveTypeRepository> GetLeaveTypes() 
        {
            var leaveTypes = new List<LeaveType>
            {
                new LeaveType
                {
                    Id = 1,
                    DefaultDays = 10,
                    Name = "Test1"
                },
                new LeaveType
                {
                    Id = 2,
                    DefaultDays = 10,
                    Name = "Test2"
                }
            };

            var mockRepo = new Mock<ILeaveTypeRepository>();

            mockRepo.Setup(r => r.GetAsync()).ReturnsAsync(leaveTypes);

            mockRepo.Setup(r => r.CreateAsync(It.IsAny<LeaveType>()))
                .Returns((LeaveType leaveType) => {
                    leaveTypes.Add(leaveType);
                    return Task.CompletedTask;
                });


            return mockRepo;
        }


        

    }

}