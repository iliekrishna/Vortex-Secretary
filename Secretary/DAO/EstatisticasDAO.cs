using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Data;
using System.Security.Cryptography;

namespace Secretary.DAO
{
    public class EstatisticasDAO
    {
        // -------------------------------
        // TOTAIS POR USUÁRIO
        // -------------------------------
        public static int TotalRequerimentosUsuario(int idUsuario, DateTime inicio, DateTime fim)
        {
            // Mantido como está (assumindo que cancelados têm data_resposta)
            string sql = @"
                SELECT COUNT(*)
                FROM t_requerimentos
                WHERE id_usuario = @id
                  AND data_resposta BETWEEN @ini AND @fim
                  AND data_resposta IS NOT NULL
                  AND status_doc IN ('Respondido', 'Cancelado')";
            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", idUsuario);
                cmd.Parameters.AddWithValue("@ini", inicio);
                cmd.Parameters.AddWithValue("@fim", fim);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        public static int TotalTicketsUsuario(int idUsuario, DateTime inicio, DateTime fim)
        {
            string sql = @"
                SELECT COUNT(*)
                FROM t_tickets
                WHERE id_usuario = @id
                  AND status IN ('Respondido', 'Cancelado')
                  AND (
                      (status = 'Respondido' AND data_resposta BETWEEN @ini AND @fim AND data_resposta IS NOT NULL)
                      OR
                      (status = 'Cancelado' AND data_pedido BETWEEN @ini AND @fim)
                  )";
            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", idUsuario);
                cmd.Parameters.AddWithValue("@ini", inicio);
                cmd.Parameters.AddWithValue("@fim", fim);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        // -------------------------------
        // TOTAIS POR CURSO
        // -------------------------------
        public static int TotalRequerimentosCurso(string curso, DateTime inicio, DateTime fim)
        {
            string sql = @"
                SELECT COUNT(*)
                FROM t_requerimentos
                WHERE curso = @curso
                  AND data_resposta BETWEEN @ini AND @fim
                  AND data_resposta IS NOT NULL
                  AND status_doc IN ('Respondido', 'Cancelado')";

            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@curso", curso);
                cmd.Parameters.AddWithValue("@ini", inicio);
                cmd.Parameters.AddWithValue("@fim", fim);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static int TotalTicketsCurso(string curso, DateTime inicio, DateTime fim)
        {
            string sql = @"
                SELECT COUNT(*)
                FROM t_tickets
                WHERE curso = @curso
                  AND status IN ('Respondido', 'Cancelado')
                  AND (
                      (status = 'Respondido' AND data_resposta BETWEEN @ini AND @fim AND data_resposta IS NOT NULL)
                      OR
                      (status = 'Cancelado' AND data_pedido BETWEEN @ini AND @fim)
                  )";
            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@curso", curso);
                cmd.Parameters.AddWithValue("@ini", inicio);
                cmd.Parameters.AddWithValue("@fim", fim);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // -------------------------------
        // TOTAIS GERAIS (SEM FILTROS)
        // -------------------------------
        public static int TotalRequerimentosGeral(DateTime inicio, DateTime fim)
        {
            string sql = @"
                SELECT COUNT(*)
                FROM t_requerimentos
                WHERE data_resposta BETWEEN @ini AND @fim
                  AND data_resposta IS NOT NULL
                  AND status_doc IN ('Respondido', 'Cancelado')";

            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@ini", inicio);
                cmd.Parameters.AddWithValue("@fim", fim);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static int TotalTicketsGeral(DateTime inicio, DateTime fim)
        {
            // Ajustado similarmente
            string sql = @"
                SELECT COUNT(*)
                FROM t_tickets
                WHERE status IN ('Respondido', 'Cancelado')
                  AND (
                      (status = 'Respondido' AND data_resposta BETWEEN @ini AND @fim AND data_resposta IS NOT NULL)
                      OR
                      (status = 'Cancelado' AND data_pedido BETWEEN @ini AND @fim)
                  )";
            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@ini", inicio);
                cmd.Parameters.AddWithValue("@fim", fim);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // -------------------------------
        // TOTAIS POR USUÁRIO E CURSO (COMBINADO)
        // -------------------------------
        public static int TotalRequerimentosUsuarioCurso(int idUsuario, string curso, DateTime inicio, DateTime fim)
        {
            string sql = @"
                SELECT COUNT(*)
                FROM t_requerimentos
                WHERE id_usuario = @id
                  AND curso = @curso
                  AND data_resposta BETWEEN @ini AND @fim
                  AND data_resposta IS NOT NULL
                  AND status_doc IN ('Respondido', 'Cancelado')";

            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", idUsuario);
                cmd.Parameters.AddWithValue("@curso", curso);
                cmd.Parameters.AddWithValue("@ini", inicio);
                cmd.Parameters.AddWithValue("@fim", fim);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static int TotalTicketsUsuarioCurso(int idUsuario, string curso, DateTime inicio, DateTime fim)
        {
            string sql = @"
                SELECT COUNT(*)
                FROM t_tickets
                WHERE id_usuario = @id
                  AND curso = @curso
                  AND status IN ('Respondido', 'Cancelado')
                  AND (
                      (status = 'Respondido' AND data_resposta BETWEEN @ini AND @fim AND data_resposta IS NOT NULL)
                      OR
                      (status = 'Cancelado' AND data_pedido BETWEEN @ini AND @fim)
                  )";
            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", idUsuario);
                cmd.Parameters.AddWithValue("@curso", curso);
                cmd.Parameters.AddWithValue("@ini", inicio);
                cmd.Parameters.AddWithValue("@fim", fim);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // -------------------------------
        // LISTAGENS PARA O DATAGRIDVIEW
        // -------------------------------


        // 1) Usuário selecionado → lista detalhada de requerimentos e tickets atendidos por esse usuário (unificada em uma DataGridView)
        public static DataTable ListarResumoPorUsuario(int idUsuario, DateTime inicio, DateTime fim)
        {
            // Ajustado: Usa UNION ALL para combinar requerimentos e tickets em uma única lista.
            // Adiciona coluna "Tipo" para distinguir.
            // Campos específicos para cada tipo, com CASE para curso e RA conforme solicitado.
            // Ordena por data_resposta DESC (requerimentos primeiro, depois tickets).
            string sql = @"
        SELECT 
            'Requerimento' AS `Tipo`,
            r.data_resposta AS `Data da Resposta`,
            r.nome_doc AS `Nome do Documento`,
            COALESCE(r.curso, 'Não informado') AS `Curso do Aluno`,
            COALESCE(r.ra, 'Não informado') AS `RA do Aluno`,
            NULL AS `Categoria`,
            NULL AS `Tipo de Vínculo`,
            NULL AS `Nome do Solicitante`
        FROM t_requerimentos r
        WHERE r.id_usuario = @id
          AND r.status_doc IN ('Respondido', 'Cancelado')
          AND r.data_resposta BETWEEN @ini AND @fim
          AND r.data_resposta IS NOT NULL
        
        UNION ALL
        
        SELECT 
            'Ticket' AS `Tipo`,
            t.data_resposta AS `Data da Resposta`,
            NULL AS `Nome do Documento`,
            CASE WHEN t.tipo_vinculo = 'Comunidade externa' THEN 'Comunidade Externa' ELSE COALESCE(t.curso, 'Não informado') END AS `Curso do Aluno`,
            COALESCE(t.ra, 'Não informado') AS `RA do Aluno`,
            t.categoria AS `Categoria`,
            t.tipo_vinculo AS `Tipo de Vínculo`,
            t.nome_aluno AS `Nome do Solicitante`
        FROM t_tickets t
        WHERE t.id_usuario = @id
          AND t.status IN ('Respondido', 'Cancelado')
          AND (
              (t.status = 'Respondido' AND t.data_resposta BETWEEN @ini AND @fim AND t.data_resposta IS NOT NULL)
              OR
              (t.status = 'Cancelado' AND t.data_pedido BETWEEN @ini AND @fim)
          )
        
        ORDER BY `Data da Resposta` DESC, `Tipo` ASC";
        
    using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            using (var ad = new MySqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@id", idUsuario);
                cmd.Parameters.AddWithValue("@ini", inicio);
                cmd.Parameters.AddWithValue("@fim", fim);

                DataTable dt = new DataTable();
                ad.Fill(dt);
                return dt;
            }
        }




        // 2) Curso selecionado → listar usuários que atenderam esse curso
        public static DataTable ListarResumoPorCurso(string curso, DateTime inicio, DateTime fim)
        {
            string sql = @"
                SELECT
                    u.nome_usuario AS 'Usuário',
                    @curso AS 'Curso',
                    COUNT(DISTINCT r.id_requerimento) AS 'Total Requerimentos',
                    (SELECT COUNT(*) FROM t_tickets t
                     WHERE t.curso = @curso
                       AND t.id_usuario = r.id_usuario
                       AND t.status IN ('Respondido', 'Cancelado')
                       AND (
                           (t.status = 'Respondido' AND t.data_resposta BETWEEN @ini AND @fim AND t.data_resposta IS NOT NULL)
                           OR
                           (t.status = 'Cancelado' AND t.data_pedido BETWEEN @ini AND @fim)
                       )) AS 'Total Tickets'
                FROM t_requerimentos r
                INNER JOIN t_usuarios u ON u.id_usuario = r.id_usuario
                WHERE r.curso = @curso
                  AND r.data_resposta BETWEEN @ini AND @fim
                  AND r.status_doc IN ('Respondido', 'Cancelado')
                  AND r.curso IS NOT NULL AND r.curso != ''
                GROUP BY r.id_usuario"; 
            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            using (var ad = new MySqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@curso", curso);
                cmd.Parameters.AddWithValue("@ini", inicio);
                cmd.Parameters.AddWithValue("@fim", fim);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                return dt;
            }
        }
        // 3) Nenhum filtro → geral por usuário e curso
        public static DataTable ListarResumoGeral(DateTime inicio, DateTime fim)
        {
            // Reescrevido sem CTE para compatibilidade com MySQL < 8.0.
            // Usa UNION ALL em subquery e GROUP BY externo para combinar cursos de requerimentos e tickets.
            // Aliases corrigidos para usar aspas invertidas (`).
            // Ajustado: Para tickets, se tipo_vinculo = 'Comunidade externa', define "Curso" como 'Comunidade Externa'; senão, usa COALESCE(t.curso, 'Sem Curso').
            string sql = @"
        SELECT 
            combined.`Usuário`,
            combined.`Curso`,
            SUM(combined.`Total Requerimentos`) AS `Total Requerimentos`,
            SUM(combined.`Total Tickets`) AS `Total Tickets`
        FROM (
            -- Parte 1: Cursos de requerimentos
            SELECT 
                u.nome_usuario AS `Usuário`,
                COALESCE(r.curso, 'Sem Curso') AS `Curso`,
                COUNT(DISTINCT r.id_requerimento) AS `Total Requerimentos`,
                0 AS `Total Tickets`
            FROM t_requerimentos r
            INNER JOIN t_usuarios u ON u.id_usuario = r.id_usuario
            WHERE r.data_resposta BETWEEN @ini AND @fim
              AND r.status_doc IN ('Respondido', 'Cancelado')
              AND COALESCE(r.curso, '') != ''  -- Exclui apenas cursos vazios, trata NULL como 'Sem Curso'
            GROUP BY u.id_usuario, COALESCE(r.curso, 'Sem Curso')
            
            UNION ALL
            
            -- Parte 2: Cursos de tickets (incluindo NULL tratado como 'Sem Curso' ou 'Comunidade Externa')
            SELECT 
                u.nome_usuario AS `Usuário`,
                CASE WHEN t.tipo_vinculo = 'Comunidade externa' THEN 'Comunidade Externa' ELSE COALESCE(t.curso, 'Sem Curso') END AS `Curso`,
                0 AS `Total Requerimentos`,
                COUNT(*) AS `Total Tickets`
            FROM t_tickets t
            INNER JOIN t_usuarios u ON u.id_usuario = t.id_usuario
            WHERE t.status IN ('Respondido', 'Cancelado')
              AND (
                  (t.status = 'Respondido' AND t.data_resposta BETWEEN @ini AND @fim AND t.data_resposta IS NOT NULL)
                  OR
                  (t.status = 'Cancelado' AND t.data_pedido BETWEEN @ini AND @fim)
              )
            GROUP BY u.id_usuario, CASE WHEN t.tipo_vinculo = 'Comunidade externa' THEN 'Comunidade Externa' ELSE COALESCE(t.curso, 'Sem Curso') END
        ) AS combined
        GROUP BY combined.`Usuário`, combined.`Curso`
        ORDER BY combined.`Usuário`, combined.`Curso`";

            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            using (var ad = new MySqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@ini", inicio);
                cmd.Parameters.AddWithValue("@fim", fim);

                DataTable dt = new DataTable();
                ad.Fill(dt);
                return dt;
            }
        }





        // -------------------------------
        // LISTAGEM PARA O DATAGRIDVIEW (USUÁRIO E CURSO COMBINADO)
        // -------------------------------


        // 4) Usuário e curso selecionados → lista detalhada de requerimentos e tickets atendidos por esse usuário para esse curso
        public static DataTable ListarResumoPorUsuarioECurso(int idUsuario, string curso, DateTime inicio, DateTime fim)
        {
            // Ajustado: Usa UNION ALL para combinar requerimentos e tickets em uma única lista detalhada.
            // Filtra por id_usuario E curso (considerando "Comunidade Externa" para tickets externos).
            // Campos específicos para cada tipo, com CASE para curso e RA conforme solicitado.
            // Ordena por data_resposta DESC (requerimentos primeiro, depois tickets).
            string sql = @"
        SELECT 
            'Requerimento' AS `Tipo`,
            r.data_resposta AS `Data da Resposta`,
            r.nome_doc AS `Nome do Documento`,
            COALESCE(r.curso, 'Não informado') AS `Curso do Aluno`,
            COALESCE(r.ra, 'Não informado') AS `RA do Aluno`,
            NULL AS `Categoria`,
            NULL AS `Tipo de Vínculo`,
            NULL AS `Nome do Solicitante`
        FROM t_requerimentos r
        WHERE r.id_usuario = @id
          AND r.curso = @curso
          AND r.status_doc IN ('Respondido', 'Cancelado')
          AND r.data_resposta BETWEEN @ini AND @fim
          AND r.data_resposta IS NOT NULL
        
        UNION ALL
        
        SELECT 
            'Ticket' AS `Tipo`,
            t.data_resposta AS `Data da Resposta`,
            NULL AS `Nome do Documento`,
            CASE WHEN t.tipo_vinculo = 'Comunidade externa' THEN 'Comunidade Externa' ELSE COALESCE(t.curso, 'Não informado') END AS `Curso do Aluno`,
            COALESCE(t.ra, 'Não informado') AS `RA do Aluno`,
            t.categoria AS `Categoria`,
            t.tipo_vinculo AS `Tipo de Vínculo`,
            t.nome_aluno AS `Nome do Solicitante`
        FROM t_tickets t
        WHERE t.id_usuario = @id
          AND CASE WHEN @curso = 'Comunidade Externa' THEN t.tipo_vinculo = 'Comunidade externa' ELSE t.curso = @curso END
          AND t.status IN ('Respondido', 'Cancelado')
          AND (
              (t.status = 'Respondido' AND t.data_resposta BETWEEN @ini AND @fim AND t.data_resposta IS NOT NULL)
              OR
              (t.status = 'Cancelado' AND t.data_pedido BETWEEN @ini AND @fim)
          )
        
        ORDER BY `Data da Resposta` DESC, `Tipo` ASC";
        
    using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            using (var ad = new MySqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@id", idUsuario);
                cmd.Parameters.AddWithValue("@curso", curso);
                cmd.Parameters.AddWithValue("@ini", inicio);
                cmd.Parameters.AddWithValue("@fim", fim);

                DataTable dt = new DataTable();
                ad.Fill(dt);
                return dt;
            }
        }


        // -------------------------------
        // CARREGAR FILTROS (MOVIDOS PARA DAO)
        // -------------------------------

        public static DataTable ObterUsuariosAtivos()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id_usuario", typeof(int));
            dt.Columns.Add("nome_usuario", typeof(string));

            // Adicionar linha "Todos"
            dt.Rows.Add(0, "Todos");

            // Adicionar usuários ativos
            string sql = "SELECT id_usuario, nome_usuario FROM t_usuarios WHERE ativo = 1 ORDER BY nome_usuario";
            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            using (var ad = new MySqlDataAdapter(cmd))
            {
                DataTable dtTemp = new DataTable();
                ad.Fill(dtTemp);
                foreach (DataRow row in dtTemp.Rows)
                {
                    dt.Rows.Add(row["id_usuario"], row["nome_usuario"]);
                }
            }
            return dt;
        }

        public static DataTable ObterCursos()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("curso", typeof(string));

            // Adicionar "Todos"
            dt.Rows.Add("Todos");

            // Adicionar cursos únicos
            string sql = @"
                SELECT DISTINCT curso FROM t_requerimentos WHERE curso IS NOT NULL AND curso != ''
                UNION
                SELECT DISTINCT curso FROM t_tickets WHERE curso IS NOT NULL AND curso != ''
                ORDER BY curso";
            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            using (var ad = new MySqlDataAdapter(cmd))
            {
                DataTable dtTemp = new DataTable();
                ad.Fill(dtTemp);
                foreach (DataRow row in dtTemp.Rows)
                {
                    dt.Rows.Add(row["curso"]);
                }
            }
            return dt;
        }
    }
}