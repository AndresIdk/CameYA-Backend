using System.Data;
using System.Data.SqlClient;
using CameYA.Core.Entities;
using CameYA.Core.Interfaces.IRespositories;
using CameYA.Infrastructure.Data.Configurations;

namespace CameYA.Infrastructure.Repositories
{
    public class WorkerRepository : IWorkerRepository
    {
        private readonly DatabaseSettings db = new();

        public async Task<List<Worker>> GetAll()
        {
            var Workers = new List<Worker>();
            try
            {
                using (var sql = new SqlConnection(db.CadSQL()))
                {
                    using (var cmd = new SqlCommand("showWorkers", sql))
                    {
                        await sql.OpenAsync();
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (var item = await cmd.ExecuteReaderAsync())
                        {
                            while (await item.ReadAsync())
                            {
                                var worker = new Worker();
                                worker.dni = item["dni"].ToString();
                                worker.name = (String)item["name"];
                                worker.age = (int)item["age"];
                                worker.email = (String)item["email"];
                                worker.password = (String)item["password"];
                                worker.phone = Convert.ToInt64(item["phone"]);
                                worker.city = (String)item["city"];
                                worker.rate = (double)item["rate"];
                                worker.detail = (String)item["detail"];
                                worker.category = (String)item["category"];
                                worker.HourPrice = (long)item["hour_price"];
                                Workers.Add(worker);

                            }
                        }
                    }
                }
                return Workers;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public Task<Worker> GetByDni(int dni)
        {
            throw new NotImplementedException();
        }

        public async Task<Worker> Insert(Worker worker)
        {
            try
            {
                using (var sql = new SqlConnection(db.CadSQL()))
                {
                    using (var cmd = new SqlCommand("insertWorker", sql))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("dni", worker.dni);
                        cmd.Parameters.AddWithValue("name", worker.name);
                        cmd.Parameters.AddWithValue("age", worker.age);
                        cmd.Parameters.AddWithValue("email", worker.email);
                        cmd.Parameters.AddWithValue("password", worker.password);
                        cmd.Parameters.AddWithValue("phone", worker.phone);
                        cmd.Parameters.AddWithValue("city", worker.city);
                        cmd.Parameters.AddWithValue("rate", worker.rate);
                        cmd.Parameters.AddWithValue("detail", worker.detail);
                        cmd.Parameters.AddWithValue("category", worker.category);
                        cmd.Parameters.AddWithValue("hour_price", worker.HourPrice);

                        await sql.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                        return worker;
                    }
                }
            }catch 
            {
                throw new NotImplementedException();
            }
        }

        public Task Update(int dni, Worker entity)
        {
            throw new NotImplementedException();
        }
        public Task Delete(int dni)
        {
            throw new NotImplementedException();
        }
    }
}

